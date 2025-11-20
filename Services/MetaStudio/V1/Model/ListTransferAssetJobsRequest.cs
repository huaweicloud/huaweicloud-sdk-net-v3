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
    /// Request Object
    /// </summary>
    public class ListTransferAssetJobsRequest 
    {
        /// <summary>
        /// 角色。 SENDER:发起方，RECEIVER：接收方。ALL全部
        /// </summary>
        /// <value>角色。 SENDER:发起方，RECEIVER：接收方。ALL全部</value>
        [JsonConverter(typeof(EnumClassConverter<RoleEnum>))]
        public class RoleEnum
        {
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly RoleEnum ALL = new RoleEnum("ALL");

            /// <summary>
            /// Enum SENDER for value: SENDER
            /// </summary>
            public static readonly RoleEnum SENDER = new RoleEnum("SENDER");

            /// <summary>
            /// Enum RECEIVER for value: RECEIVER
            /// </summary>
            public static readonly RoleEnum RECEIVER = new RoleEnum("RECEIVER");

            private static readonly Dictionary<string, RoleEnum> StaticFields =
            new Dictionary<string, RoleEnum>()
            {
                { "ALL", ALL },
                { "SENDER", SENDER },
                { "RECEIVER", RECEIVER },
            };

            private string _value;

            public RoleEnum()
            {

            }

            public RoleEnum(string value)
            {
                _value = value;
            }

            public static RoleEnum FromValue(string value)
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

                if (this.Equals(obj as RoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoleEnum a, RoleEnum b)
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

            public static bool operator !=(RoleEnum a, RoleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。  格式为(YYYYMMDD&#39;T&#39;HHMMSS&#39;Z&#39;)。
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 第三方用户ID。不允许输入中文。
        /// </summary>
        [SDKProperty("X-App-UserId", IsHeader = true)]
        [JsonProperty("X-App-UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string XAppUserId { get; set; }

        /// <summary>
        /// 角色。 SENDER:发起方，RECEIVER：接收方。ALL全部
        /// </summary>
        [SDKProperty("role", IsQuery = true)]
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// 任务状态。多个状态使用英文逗号分隔。 - PROCESSING: 处理过程中 - ACCEPT： 接受 - REJECT： 拒绝 - CANCEL：取消 - FAIL: 失败
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 任务类型。默认查询TRANSFER_OUT类型任务。 - TRANSFER_OUT: 资产转出 - TRANSFER_BACK： 资产转回
        /// </summary>
        [SDKProperty("transfer_type", IsQuery = true)]
        [JsonProperty("transfer_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransferAssetJobsRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  xAppUserId: ").Append(XAppUserId).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  transferType: ").Append(TransferType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTransferAssetJobsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTransferAssetJobsRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.XAppUserId != input.XAppUserId || (this.XAppUserId != null && !this.XAppUserId.Equals(input.XAppUserId))) return false;
            if (this.Role != input.Role) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.TransferType != input.TransferType || (this.TransferType != null && !this.TransferType.Equals(input.TransferType))) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.XAppUserId != null) hashCode = hashCode * 59 + this.XAppUserId.GetHashCode();
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TransferType != null) hashCode = hashCode * 59 + this.TransferType.GetHashCode();
                return hashCode;
            }
        }
    }
}
