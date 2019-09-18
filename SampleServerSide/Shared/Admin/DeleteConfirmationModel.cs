using System.ComponentModel.DataAnnotations;

namespace SampleServerSide.Shared
{
    public class DeleteConfirmationModel
    {
        public string CompareValue { get; set; }

        [Compare(otherProperty: nameof(DeleteConfirmationModel.CompareValue),
            ErrorMessage = "Value did not match reference")]
        [Required]
        public string CompareInput { get; set; }
    }
}
