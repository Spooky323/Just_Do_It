using Zenject;
using Just_Do_It.Controllers;

namespace Just_Do_It.Installers
{
    class MenuInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<TextController>().AsSingle();
        }
    }
}
