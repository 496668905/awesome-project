using System.ComponentModel.DataAnnotations;

namespace IHuangPu.StrategyPlatform.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}