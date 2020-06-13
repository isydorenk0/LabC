using System.Text;
using static LabC.Screen;

namespace LabC
{
    class MobilePhone
    {
        public abstract class Mobile
        {
            public abstract ScreenBase Screen { get; }
            private void Show(IScreenImage screenImage)
            {
                Screen.Show(screenImage);
            }
            public abstract BatteryBasic Battery { get; }
            public abstract DisplayBasic Display    { get; }
            public string GetDescription()
            {
                var descriptionBuilder = new StringBuilder();
                descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
                descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
                descriptionBuilder.AppendLine($"Display Type: {Display.ToString()}");
                return descriptionBuilder.ToString();
            }
        }

        public class SimCorpMobile : Mobile
        {
            public override ScreenBase Screen { get { return vOLDEScreen; } }
            private readonly OLEDScreen vOLDEScreen = new OLEDScreen();
            public override BatteryBasic Battery { get { return vLiIonBattery; } }
            private readonly LiIonBattery vLiIonBattery = new LiIonBattery();
            public override DisplayBasic Display{ get { return vMultiDisplay; } }
            private readonly MultiTouch vMultiDisplay = new MultiTouch();

        }

    }
}
