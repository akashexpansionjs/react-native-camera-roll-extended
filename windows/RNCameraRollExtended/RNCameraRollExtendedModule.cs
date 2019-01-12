using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Camera.Roll.Extended.RNCameraRollExtended
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCameraRollExtendedModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCameraRollExtendedModule"/>.
        /// </summary>
        internal RNCameraRollExtendedModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCameraRollExtended";
            }
        }
    }
}
