//---------------------------------------------------------------------------------------------
/// Copyright (c) Microsoft Corporation. All rights reserved.
/// Licensed under the MIT License. See License.txt in the project root for license information.
//---------------------------------------------------------------------------------------------

namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using System;

    public partial class VMExtension
    {
        // private string _publisher = null;

        private string _extensionType = null;

        private string _typeHandlerVersion = null;

        /*
        public string Publisher 
        { 
            get {
                if (_publisher == null)
                {
                    var idArray = this.Id.Split('/');
                    _publisher = idArray[Array.IndexOf(idArray, "publishers")+1];
                }

                return _publisher;
            } 
        }
        */

        public string ExtensionType 
        { 
            get {
                if (_extensionType == null)
                {
                    var idArray = this.Id.Split('/');
                    _extensionType = idArray[Array.IndexOf(idArray, "types")+1];
                }

                return _extensionType;
            } 
        }

        public string TypeHandlerVersion 
        { 
            get {
                if (_typeHandlerVersion == null)
                {
                    var idArray = this.Id.Split('/');
                    _typeHandlerVersion = idArray[Array.IndexOf(idArray, "versions")+1];
                }

                return _typeHandlerVersion;
            } 
        }
    }
}