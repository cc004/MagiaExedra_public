using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crypto;

namespace MagiaClient.Models
{
    public class ResourceMstRecord
    {
        public int pathId;
        public string language;
        public string name;
        public int expireType;
        public string label;
        public string cryptoKey;
        public int size;
        public string revision;
        public string crc;

        public string root;

        public bool isEncrypted = true;
        public bool isRenamedName;

        internal ResourceMstRecord Clone() => (ResourceMstRecord)MemberwiseClone();
    }

    public class ResourceFilePathMappingMstRecord
    {
        public int pathId;
        public string path;
    }

    public class ResourceMstListResponse : ResponseBase
    {
        public ResourceMstRecord[] mstList;
        public ResourceFilePathMappingMstRecord[] pathMappingMstList;

        public ResourceMstRecord[] ToArray()
        {
            var pathDict = pathMappingMstList.ToDictionary(p => p.pathId, p => p.path);
            return mstList.Select(x =>
            {
                var record = x.Clone();
                record.name = pathDict[record.pathId] + record.name;
                return record;
            }).ToArray();
        }
    }

    public abstract class MstRequestBase<TResponse> : RequestBase<TResponse> where TResponse : ResponseBase
    {
        protected MstRequestBase(string hash)
        {
            this.hash = hash;
        }

        protected string hash;

        protected abstract string PartialUrl { get; }

        protected abstract string PlatformHash { get; }
        public sealed override string Url =>
            hash == null ? PartialUrl + "?" :
                $"{PartialUrl}?key=" +
                $"{LocalStorageUtility.ConvertIdToHash(PlatformHash)}{LocalStorageUtility.ConvertIdToHash(AssetCrypto.JAPAN_TAG)}" +
                $"{hash}&";
    }
    public class GetResourceAssetBundleMstListRequest : MstRequestBase<ResourceMstListResponse>
    {
        protected override string PlatformHash => "GetResourceAssetBundleMstList:Android";
        protected override string PartialUrl => "/api/mst/get_resource_asset_bundle_mst_list";

        public GetResourceAssetBundleMstListRequest(string hash = null) : base(hash)
        {
        }
    }
    public class GetResourceFileMstListRequest : MstRequestBase<ResourceMstListResponse>
    {
        protected override string PlatformHash => throw new NotImplementedException();
        protected override string PartialUrl => "/api/mst/get_resource_file_mst_list";
        public GetResourceFileMstListRequest(string hash = null) : base(hash)
        {
        }
    }
    public class GetResourceMasterDataMstListRequest : MstRequestBase<ResourceMstListResponse>
    {
        protected override string PlatformHash => throw new NotImplementedException();
        protected override string PartialUrl => "/api/mst/get_resource_master_data_mst_list";
        public GetResourceMasterDataMstListRequest(string hash = null) : base(hash)
        {
        }
    }
}
