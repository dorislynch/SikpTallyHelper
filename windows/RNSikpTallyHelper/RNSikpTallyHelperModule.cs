using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Sikp.Tally.Helper.RNSikpTallyHelper
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSikpTallyHelperModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSikpTallyHelperModule"/>.
        /// </summary>
        internal RNSikpTallyHelperModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSikpTallyHelper";
            }
        }
    }
}
