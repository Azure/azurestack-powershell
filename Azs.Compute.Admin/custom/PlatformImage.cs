namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview
{
    using System;

    public partial class PlatformImage
    {
        private string _publisher = null;

        private string _offer = null;

        private string _sku = null;

        private string _version = null;

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

        public string Offer 
        { 
            get {
                if (_offer == null)
                {
                    var idArray = this.Id.Split('/');
                    _offer = idArray[Array.IndexOf(idArray, "offers")+1];
                }

                return _offer;
            } 
        }

        public string Sku 
        { 
            get {
                if (_sku == null)
                {
                    var idArray = this.Id.Split('/');
                    _sku = idArray[Array.IndexOf(idArray, "skus")+1];
                }

                return _sku;
            } 
        }

        public string Version 
        { 
            get {
                if (_version == null)
                {
                    var idArray = this.Id.Split('/');
                    _version = idArray[Array.IndexOf(idArray, "versions")+1];
                }

                return _version;
            } 
        }
    }
}