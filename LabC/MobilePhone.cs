using System.Text;
using static LabC.Screen;

namespace LabC
{
    public abstract class MobilePhone
    {

        //public abstract ScreenBase Screen { get; }
        //private void Show(IScreenImage screenImage)
        //{
        //    Screen.Show(screenImage);
        //}

        //public abstract DisplayBasic Display    { get; }
        public abstract ESimCard ESimCard { get; }
        public abstract BatteryBasic BatteryBasic { get; }
        public abstract DisplayTouch TouchDisplay { get; }
        public abstract BodyBasic Body { get; }
        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();           
            descriptionBuilder.AppendLine($"SimCard Info:\n{ESimCard.ToString()}");
            descriptionBuilder.AppendLine($"Battery Info:\n{BatteryBasic.ToString()}");
            descriptionBuilder.AppendLine($"Display Info:\n{TouchDisplay.ToString()}");
            descriptionBuilder.AppendLine($"Body Info:\n{Body.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
