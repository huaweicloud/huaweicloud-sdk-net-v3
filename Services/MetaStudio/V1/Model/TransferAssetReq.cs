using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 资产转移请求
    /// </summary>
    public class TransferAssetReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transfer_type", NullValueHandling = NullValueHandling.Ignore)]
        public TransferTypeEnum? TransferType { get; set; }

        /// <summary>
        /// 资产ID列表
        /// </summary>
        [JsonProperty("asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetIds { get; set; }

        /// <summary>
        /// 目标用户ID
        /// </summary>
        [JsonProperty("dest_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestProjectId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 是否自动接收,管理员可用
        /// </summary>
        [JsonProperty("auto_accept", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAccept { get; set; }

        /// <summary>
        /// 是否自动激活,管理员可用
        /// </summary>
        [JsonProperty("auto_active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoActive { get; set; }

        /// <summary>
        /// 资产转移时，是否需要从接收方扣减资源（产生计费话单）
        /// </summary>
        [JsonProperty("is_need_billing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNeedBilling { get; set; }

        /// <summary>
        /// 转移任务ID，仅在transfer_type&#x3D;TRANSFER_BACK时需要填写。
        /// </summary>
        [JsonProperty("transfer_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferJobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferAssetReq {\n");
            sb.Append("  transferType: ").Append(TransferType).Append("\n");
            sb.Append("  assetIds: ").Append(AssetIds).Append("\n");
            sb.Append("  destProjectId: ").Append(DestProjectId).Append("\n");
            sb.Append("  memo: ").Append(Memo).Append("\n");
            sb.Append("  autoAccept: ").Append(AutoAccept).Append("\n");
            sb.Append("  autoActive: ").Append(AutoActive).Append("\n");
            sb.Append("  isNeedBilling: ").Append(IsNeedBilling).Append("\n");
            sb.Append("  transferJobId: ").Append(TransferJobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferAssetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferAssetReq input)
        {
            if (input == null) return false;
            if (this.TransferType != input.TransferType || (this.TransferType != null && !this.TransferType.Equals(input.TransferType))) return false;
            if (this.AssetIds != input.AssetIds || (this.AssetIds != null && input.AssetIds != null && !this.AssetIds.SequenceEqual(input.AssetIds))) return false;
            if (this.DestProjectId != input.DestProjectId || (this.DestProjectId != null && !this.DestProjectId.Equals(input.DestProjectId))) return false;
            if (this.Memo != input.Memo || (this.Memo != null && !this.Memo.Equals(input.Memo))) return false;
            if (this.AutoAccept != input.AutoAccept || (this.AutoAccept != null && !this.AutoAccept.Equals(input.AutoAccept))) return false;
            if (this.AutoActive != input.AutoActive || (this.AutoActive != null && !this.AutoActive.Equals(input.AutoActive))) return false;
            if (this.IsNeedBilling != input.IsNeedBilling || (this.IsNeedBilling != null && !this.IsNeedBilling.Equals(input.IsNeedBilling))) return false;
            if (this.TransferJobId != input.TransferJobId || (this.TransferJobId != null && !this.TransferJobId.Equals(input.TransferJobId))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.TransferType != null) hashCode = hashCode * 59 + this.TransferType.GetHashCode();
                if (this.AssetIds != null) hashCode = hashCode * 59 + this.AssetIds.GetHashCode();
                if (this.DestProjectId != null) hashCode = hashCode * 59 + this.DestProjectId.GetHashCode();
                if (this.Memo != null) hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.AutoAccept != null) hashCode = hashCode * 59 + this.AutoAccept.GetHashCode();
                if (this.AutoActive != null) hashCode = hashCode * 59 + this.AutoActive.GetHashCode();
                if (this.IsNeedBilling != null) hashCode = hashCode * 59 + this.IsNeedBilling.GetHashCode();
                if (this.TransferJobId != null) hashCode = hashCode * 59 + this.TransferJobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
