using System.ComponentModel.DataAnnotations;

namespace jQueryCRUDMy.Context {
    public class User {
        public int UserId {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Contact No")]
        public string ContactNo {
            get; set;
        }
    }
}