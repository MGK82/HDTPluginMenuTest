using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hearthstone_Deck_Tracker.Plugins;

namespace PluginTest
{
  public class Class1 : IPlugin {
    public string Name => "PluginTest";

    public string Description => Name;

    public string ButtonText => Name;

    public string Author => Name;

    public Version Version => new Version(0,0,0,0);

    public System.Windows.Controls.MenuItem MenuItem => new UserControl1();

    public void OnButtonPress() {
    }

    public void OnLoad() {
    }

    public void OnUnload() {
    }

    public void OnUpdate() {
    }
  }
}
