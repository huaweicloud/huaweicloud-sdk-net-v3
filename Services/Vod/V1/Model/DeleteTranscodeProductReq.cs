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
    /// 
    /// </summary>
    public class DeleteTranscodeProductReq 
    {
        /// <summary>
        /// GROUP：模板组级删除。 PRODUCT：产物级删除
        /// </summary>
        /// <value>GROUP：模板组级删除。 PRODUCT：产物级删除</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteTypeEnum>))]
        public class DeleteTypeEnum
        {
            /// <summary>
            /// Enum GROUP for value: GROUP
            /// </summary>
            public static readonly DeleteTypeEnum GROUP = new DeleteTypeEnum("GROUP");

            /// <summary>
            /// Enum PRODUCT for value: PRODUCT
            /// </summary>
            public static readonly DeleteTypeEnum PRODUCT = new DeleteTypeEnum("PRODUCT");

            private static readonly Dictionary<string, DeleteTypeEnum> StaticFields =
            new Dictionary<string, DeleteTypeEnum>()
            {
                { "GROUP", GROUP },
                { "PRODUCT", PRODUCT },
            };

            private string _value;

            public DeleteTypeEnum()
            {

            }

            public DeleteTypeEnum(string value)
            {
                _value = value;
            }

            public static DeleteTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteTypeEnum a, DeleteTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DeleteTypeEnum a, DeleteTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 媒资Id
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// GROUP：模板组级删除。 PRODUCT：产物级删除
        /// </summary>
        [JsonProperty("delete_type", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteTypeEnum DeleteType { get; set; }
        /// <summary>
        /// 删除的产物信息
        /// </summary>
        [JsonProperty("delete_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductGroupInfo> DeleteInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTranscodeProductReq {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  deleteType: ").Append(DeleteType).Append("\n");
            sb.Append("  deleteInfos: ").Append(DeleteInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTranscodeProductReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTranscodeProductReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.DeleteType == input.DeleteType ||
                    (this.DeleteType != null &&
                    this.DeleteType.Equals(input.DeleteType))
                ) && 
                (
                    this.DeleteInfos == input.DeleteInfos ||
                    this.DeleteInfos != null &&
                    input.DeleteInfos != null &&
                    this.DeleteInfos.SequenceEqual(input.DeleteInfos)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AssetId != null)
                    hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.DeleteType != null)
                    hashCode = hashCode * 59 + this.DeleteType.GetHashCode();
                if (this.DeleteInfos != null)
                    hashCode = hashCode * 59 + this.DeleteInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
