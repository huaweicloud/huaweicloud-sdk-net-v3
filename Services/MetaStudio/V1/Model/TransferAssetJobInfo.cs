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
    /// 
    /// </summary>
    public class TransferAssetJobInfo 
    {
        /// <summary>
        /// 任务状态 - PROCESSING: 处理过程中 - ACCEPT： 接受 - REJECT： 拒绝 - CANCEL：取消 - FAIL: 失败
        /// </summary>
        /// <value>任务状态 - PROCESSING: 处理过程中 - ACCEPT： 接受 - REJECT： 拒绝 - CANCEL：取消 - FAIL: 失败</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            public static readonly StateEnum PROCESSING = new StateEnum("PROCESSING");

            /// <summary>
            /// Enum ACCEPT for value: ACCEPT
            /// </summary>
            public static readonly StateEnum ACCEPT = new StateEnum("ACCEPT");

            /// <summary>
            /// Enum REJECT for value: REJECT
            /// </summary>
            public static readonly StateEnum REJECT = new StateEnum("REJECT");

            /// <summary>
            /// Enum CANCEL for value: CANCEL
            /// </summary>
            public static readonly StateEnum CANCEL = new StateEnum("CANCEL");

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            public static readonly StateEnum FAIL = new StateEnum("FAIL");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "PROCESSING", PROCESSING },
                { "ACCEPT", ACCEPT },
                { "REJECT", REJECT },
                { "CANCEL", CANCEL },
                { "FAIL", FAIL },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 转移资产任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transfer_type", NullValueHandling = NullValueHandling.Ignore)]
        public TransferTypeEnum? TransferType { get; set; }

        /// <summary>
        /// 转移资产列表
        /// </summary>
        [JsonProperty("transfer_assets", NullValueHandling = NullValueHandling.Ignore)]
        public List<DigitalAssetSummary> TransferAssets { get; set; }

        /// <summary>
        /// 任务状态 - PROCESSING: 处理过程中 - ACCEPT： 接受 - REJECT： 拒绝 - CANCEL：取消 - FAIL: 失败
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 源用户ID
        /// </summary>
        [JsonProperty("src_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProjectId { get; set; }

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
        /// 冻结/解冻原因。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 资产转移开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 资产转移完成时间
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 资产转移过期时间
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 资产转移时，是否需要从接收方扣减资源（产生计费话单）
        /// </summary>
        [JsonProperty("is_need_billing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNeedBilling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferAssetJobInfo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  transferType: ").Append(TransferType).Append("\n");
            sb.Append("  transferAssets: ").Append(TransferAssets).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  srcProjectId: ").Append(SrcProjectId).Append("\n");
            sb.Append("  destProjectId: ").Append(DestProjectId).Append("\n");
            sb.Append("  memo: ").Append(Memo).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  isNeedBilling: ").Append(IsNeedBilling).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferAssetJobInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferAssetJobInfo input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.TransferType != input.TransferType || (this.TransferType != null && !this.TransferType.Equals(input.TransferType))) return false;
            if (this.TransferAssets != input.TransferAssets || (this.TransferAssets != null && input.TransferAssets != null && !this.TransferAssets.SequenceEqual(input.TransferAssets))) return false;
            if (this.State != input.State) return false;
            if (this.SrcProjectId != input.SrcProjectId || (this.SrcProjectId != null && !this.SrcProjectId.Equals(input.SrcProjectId))) return false;
            if (this.DestProjectId != input.DestProjectId || (this.DestProjectId != null && !this.DestProjectId.Equals(input.DestProjectId))) return false;
            if (this.Memo != input.Memo || (this.Memo != null && !this.Memo.Equals(input.Memo))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.IsNeedBilling != input.IsNeedBilling || (this.IsNeedBilling != null && !this.IsNeedBilling.Equals(input.IsNeedBilling))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.TransferType != null) hashCode = hashCode * 59 + this.TransferType.GetHashCode();
                if (this.TransferAssets != null) hashCode = hashCode * 59 + this.TransferAssets.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SrcProjectId != null) hashCode = hashCode * 59 + this.SrcProjectId.GetHashCode();
                if (this.DestProjectId != null) hashCode = hashCode * 59 + this.DestProjectId.GetHashCode();
                if (this.Memo != null) hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.IsNeedBilling != null) hashCode = hashCode * 59 + this.IsNeedBilling.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
