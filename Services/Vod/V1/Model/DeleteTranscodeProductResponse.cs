using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteTranscodeProductResponse : SdkResponse
    {
        /// <summary>
        /// SUCCESS：成功 FAIL：失败 PARTIAL_SUCCESS：部分成功 
        /// </summary>
        /// <value>SUCCESS：成功 FAIL：失败 PARTIAL_SUCCESS：部分成功 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("SUCCESS");

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            public static readonly StatusEnum FAIL = new StatusEnum("FAIL");

            /// <summary>
            /// Enum PARTIAL_SUCCESS for value: PARTIAL_SUCCESS
            /// </summary>
            public static readonly StatusEnum PARTIAL_SUCCESS = new StatusEnum("PARTIAL_SUCCESS");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "SUCCESS", SUCCESS },
                { "FAIL", FAIL },
                { "PARTIAL_SUCCESS", PARTIAL_SUCCESS },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 媒资ID
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// SUCCESS：成功 FAIL：失败 PARTIAL_SUCCESS：部分成功 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 删除成功的产物
        /// </summary>
        [JsonProperty("deleted_products", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductGroupInfo> DeletedProducts { get; set; }

        /// <summary>
        /// 删除失败的产物
        /// </summary>
        [JsonProperty("failed_products", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductGroupDelFailInfo> FailedProducts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTranscodeProductResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  deletedProducts: ").Append(DeletedProducts).Append("\n");
            sb.Append("  failedProducts: ").Append(FailedProducts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTranscodeProductResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTranscodeProductResponse input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.Status != input.Status) return false;
            if (this.DeletedProducts != input.DeletedProducts || (this.DeletedProducts != null && input.DeletedProducts != null && !this.DeletedProducts.SequenceEqual(input.DeletedProducts))) return false;
            if (this.FailedProducts != input.FailedProducts || (this.FailedProducts != null && input.FailedProducts != null && !this.FailedProducts.SequenceEqual(input.FailedProducts))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DeletedProducts != null) hashCode = hashCode * 59 + this.DeletedProducts.GetHashCode();
                if (this.FailedProducts != null) hashCode = hashCode * 59 + this.FailedProducts.GetHashCode();
                return hashCode;
            }
        }
    }
}
