using FluentValidation;
using System.Globalization;
using System.Net.Mail;
using System.Text.RegularExpressions;
using User_Management.Commands;

namespace User_Management
{
    public class CreateUserValidator : AbstractValidator<AddUserCommand>
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.EmailId).Must(Validate_EmailId).WithMessage("EmailId is invalid");
            RuleFor(x => x.DateOfBirth).Must(Validate_DOB).WithMessage("User has to be above 18 years");

        }

        private bool Validate_EmailId(string mailId)
        {
            {
                if (string.IsNullOrWhiteSpace(mailId))
                    return false;

                try
                {
                    mailId = Regex.Replace(mailId, @"(@)(.+)$", DomainMapper,
                                          RegexOptions.None, TimeSpan.FromMilliseconds(200));

                    string DomainMapper(Match match)
                    {
                        var idn = new IdnMapping();

                        string domainName = idn.GetAscii(match.Groups[2].Value);

                        return match.Groups[1].Value + domainName;
                    }
                }
                catch (RegexMatchTimeoutException e)
                {
                    return false;
                }
                catch (ArgumentException e)
                {
                    return false;
                }

                try
                {
                    return Regex.IsMatch(mailId,
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                }
                catch (RegexMatchTimeoutException)
                {
                    return false;
                }
            }
        }

        private bool Validate_DOB(DateTime date)
        {
            DateTime today = DateTime.Today;
            DateTime userDOB = DateTime.Parse(date.ToString());
            double yearsGap = (today - userDOB).Days / 365;
            if(yearsGap > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
