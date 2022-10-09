using System.Collections.Generic;

namespace NetCoreMVCRoute.Models.ViewModels
{
    public class UserInfoVM
    {
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string InformationText { get; set; }
        public List<string> Roles { get; set; }
    }
}
