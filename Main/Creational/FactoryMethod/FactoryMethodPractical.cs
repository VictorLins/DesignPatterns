namespace Main.Factory
{
    public static class FactoryMethodPractical
    {
        public static void Execute()
        {
            ICellphoneFactory lCellphoneFactory = new SamsungFactory();
            ICellphone lCellphone = lCellphoneFactory.GetCellphone("GalaxyS22");
            Console.WriteLine(lCellphone.GetReleasedYear());
            lCellphone = lCellphoneFactory.GetCellphone("GalaxyS20");
            Console.WriteLine(lCellphone.GetReleasedYear());

            lCellphoneFactory = new IPhoneFactory();
            lCellphone = lCellphoneFactory.GetCellphone("IPhone13");
            Console.WriteLine(lCellphone.GetReleasedYear());
            lCellphone = lCellphoneFactory.GetCellphone("IPhone12");
            Console.WriteLine(lCellphone.GetReleasedYear());
        }
    }

    public interface ICellphone
    {
        string GetReleasedYear();
    }

    public class GalaxyS22 : ICellphone
    {
        public string GetReleasedYear() { return "GalaxyS22 - Released Year: 2022"; }
    }

    public class GalaxyS20 : ICellphone
    {
        public string GetReleasedYear() { return "GalaxyS20 - Released Year: 2020"; }
    }

    public class IPhone13 : ICellphone
    {
        public string GetReleasedYear() { return "IPhone13 - Released Year: 2021"; }
    }

    public class IPhone12 : ICellphone
    {
        public string GetReleasedYear() { return "IPhone12 - Released Year: 2020"; }
    }

    public interface ICellphoneFactory
    {
        ICellphone GetCellphone(string prModel);
    }

    public class SamsungFactory : ICellphoneFactory
    {
        public ICellphone GetCellphone(string prModel)
        {
            if (prModel == "GalaxyS22")
                return new GalaxyS22();
            else
                return new GalaxyS20();
        }
    }

    public class IPhoneFactory : ICellphoneFactory
    {
        public ICellphone GetCellphone(string prModel)
        {
            if (prModel == "IPhone13")
                return new IPhone13();
            else
                return new IPhone12();
        }
    }
}