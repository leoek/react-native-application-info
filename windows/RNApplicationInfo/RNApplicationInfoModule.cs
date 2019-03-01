using Newtonsoft.Json.Linq;
using ReactNative.Bridge;
using System;
using System.Linq;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.Storage;
using Windows.Storage.Pickers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace RNApplicationInfo
{
    class RNApplicationInfoModule : ReactContextNativeModuleBase, ILifecycleEventListener
    {

#if LOG
        protected bool withLog => true;
#else
        protected bool withLog => false;
#endif
#if BUNDLE
        protected bool withBundle => true;
#else
        protected bool withBundle => false;
#endif

        public RNApplicationInfoModule(ReactContext reactContext)
            : base(reactContext)
        {
        }

        public override string Name
        {
            get
            {
                return "RNApplicationInfo";
            }
        }

        [Obsolete]
        public override IReadOnlyDictionary<string, object> Constants
        {
            get
            {
                var constants = new Dictionary<string, object>
                {
                    { "withLog", withLog },
                    { "withBundle", withBundle }
                };

                return constants;
            }
        }

    }
}
