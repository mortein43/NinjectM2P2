using Ninject;
using NinjectM2P2.Cocktails;
using NinjectM2P2.Devices;
using NinjectM2P2.Figures;
using NinjectM2P2.GameCharacters;

namespace NinjectM2P2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Завдання 1:");
        IKernel kernel1 = new StandardKernel();
        kernel1.Bind<ICocktailService>().To<CocktailService>().InSingletonScope();
        kernel1.Bind<IOutputService>().To<ConsoleOutput>().InSingletonScope();
        kernel1.Bind<IFileService>().To<FileService>().InSingletonScope();
        kernel1.Bind<CocktailApp>().ToSelf().InSingletonScope();

        var app = kernel1.Get<CocktailApp>();
        app.Run();


        Console.WriteLine("\nЗавдання 2:");
        IKernel kernel2 = new StandardKernel();
        kernel2.Bind<ICharacterService>().To<CharacterService>().InSingletonScope();
        kernel2.Bind<IOutputService>().To<ConsoleOutput>().InSingletonScope();
        kernel2.Bind<IFileService>().To<FileService>().InSingletonScope();
        kernel2.Bind<GameCharactersApp>().ToSelf().InSingletonScope();

        var app2 = kernel2.Get<GameCharactersApp>();
        app2.Run();


        Console.WriteLine("\nЗавдання 3:");
        IKernel kernel3 = new StandardKernel();
        kernel3.Bind<IFigureService>().To<FigureService>().InSingletonScope();
        kernel3.Bind<IOutputService>().To<ConsoleOutput>().InSingletonScope();
        kernel3.Bind<IFileService>().To<FileService>().InSingletonScope();
        kernel3.Bind<FigureApp>().ToSelf().InSingletonScope();

        var app3 = kernel3.Get<FigureApp>();
        app3.Run();


        Console.WriteLine("\nЗавдання 4:");
        IKernel kernel4 = new StandardKernel();
        kernel4.Bind<IDeviceService>().To<DeviceService>().InSingletonScope();
        kernel4.Bind<IOutputService>().To<ConsoleOutput>().InSingletonScope();
        kernel4.Bind<IFileService>().To<FileService>().InSingletonScope();
        kernel4.Bind<DeviceApp>().ToSelf().InSingletonScope();

        var app4 = kernel4.Get<DeviceApp>();
        app4.Run();
    }
}