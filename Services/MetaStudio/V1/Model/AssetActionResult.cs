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
    /// 资产操作结果
    /// </summary>
    public class AssetActionResult 
    {
        /// <summary>
        /// 处理状态。 * SUCCESS：成功 * FAILED：失败
        /// </summary>
        /// <value>处理状态。 * SUCCESS：成功 * FAILED：失败</value>
        [JsonConverter(typeof(EnumClassConverter<RetStatusEnum>))]
        public class RetStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            public static readonly RetStatusEnum SUCCESS = new RetStatusEnum("SUCCESS");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly RetStatusEnum FAILED = new RetStatusEnum("FAILED");

            private static readonly Dictionary<string, RetStatusEnum> StaticFields =
            new Dictionary<string, RetStatusEnum>()
            {
                { "SUCCESS", SUCCESS },
                { "FAILED", FAILED },
            };

            private string _value;

            public RetStatusEnum()
            {

            }

            public RetStatusEnum(string value)
            {
                _value = value;
            }

            public static RetStatusEnum FromValue(string value)
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

                if (this.Equals(obj as RetStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RetStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RetStatusEnum a, RetStatusEnum b)
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

            public static bool operator !=(RetStatusEnum a, RetStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 处理状态。 * SUCCESS：成功 * FAILED：失败
        /// </summary>
        [JsonProperty("ret_status", NullValueHandling = NullValueHandling.Ignore)]
        public RetStatusEnum RetStatus { get; set; }
        /// <summary>
        /// 资产ID列表
        /// </summary>
        [JsonProperty("asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetIds { get; set; }

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
            sb.Append("class AssetActionResult {\n");
            sb.Append("  retStatus: ").Append(RetStatus).Append("\n");
            sb.Append("  assetIds: ").Append(AssetIds).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetActionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetActionResult input)
        {
            if (input == null) return false;
            if (this.RetStatus != input.RetStatus) return false;
            if (this.AssetIds != input.AssetIds || (this.AssetIds != null && input.AssetIds != null && !this.AssetIds.SequenceEqual(input.AssetIds))) return false;
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
                hashCode = hashCode * 59 + this.RetStatus.GetHashCode();
                if (this.AssetIds != null) hashCode = hashCode * 59 + this.AssetIds.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
