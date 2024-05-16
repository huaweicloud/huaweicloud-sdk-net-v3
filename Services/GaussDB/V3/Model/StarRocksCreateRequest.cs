using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StarRocksCreateRequest 
    {
        /// <summary>
        /// 可用区类型。 当前仅支持single。
        /// </summary>
        /// <value>可用区类型。 当前仅支持single。</value>
        [JsonConverter(typeof(EnumClassConverter<AzModeEnum>))]
        public class AzModeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: single
            /// </summary>
            public static readonly AzModeEnum SINGLE = new AzModeEnum("single");

            private static readonly Dictionary<string, AzModeEnum> StaticFields =
            new Dictionary<string, AzModeEnum>()
            {
                { "single", SINGLE },
            };

            private string _value;

            public AzModeEnum()
            {

            }

            public AzModeEnum(string value)
            {
                _value = value;
            }

            public static AzModeEnum FromValue(string value)
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

                if (this.Equals(obj as AzModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AzModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AzModeEnum a, AzModeEnum b)
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

            public static bool operator !=(AzModeEnum a, AzModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例名称。同一租户下，同类型的实例名可重名。  取值范围：最小为4个字符，最大为64个字符且不超过64个字节，必须以字母开头，区分大小写，可以包含字母、数字、中划线、下划线，不能包含其他特殊字符。不支持中文名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public StarRocksCreateRequestEngine Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ha", NullValueHandling = NullValueHandling.Ignore)]
        public StarRocksCreateRequestHa Ha { get; set; }

        /// <summary>
        /// FE节点规格ID。使用可通过查询HTAP规格响应消息中的“id”。
        /// </summary>
        [JsonProperty("fe_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FeFlavorId { get; set; }

        /// <summary>
        /// BE节点规格ID。使用可通过查询HTAP规格响应消息中的“id”。
        /// </summary>
        [JsonProperty("be_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BeFlavorId { get; set; }

        /// <summary>
        /// 数据库密码。  取值范围：至少包含以下字符的三种：大小写字母、数字和特殊符号~!@#$%^*-_&#x3D;+?,()&amp;|.，长度8~32个字符。 建议您输入高强度密码，以提高安全性，防止出现密码被暴力破解等安全风险。如果您输入弱密码，系统会自动判定密码非法。
        /// </summary>
        [JsonProperty("db_root_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string DbRootPwd { get; set; }

        /// <summary>
        /// FE节点数。 - 单机时固定为1 - 集群时取值[3, 10]
        /// </summary>
        [JsonProperty("fe_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FeCount { get; set; }

        /// <summary>
        /// BE节点数。 - 单机时固定为1 - 集群时取值[3, 10]
        /// </summary>
        [JsonProperty("be_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BeCount { get; set; }

        /// <summary>
        /// 可用区类型。 当前仅支持single。
        /// </summary>
        [JsonProperty("az_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AzModeEnum AzMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fe_volume", NullValueHandling = NullValueHandling.Ignore)]
        public StarRocksCreateRequestFeVolume FeVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("be_volume", NullValueHandling = NullValueHandling.Ignore)]
        public StarRocksCreateRequestBeVolume BeVolume { get; set; }

        /// <summary>
        /// 可用区代码。
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 时区。默认时区为UTC+08:00。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tags_info", NullValueHandling = NullValueHandling.Ignore)]
        public StarRocksCreateRequestTagsInfo TagsInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarRocksCreateRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  ha: ").Append(Ha).Append("\n");
            sb.Append("  feFlavorId: ").Append(FeFlavorId).Append("\n");
            sb.Append("  beFlavorId: ").Append(BeFlavorId).Append("\n");
            sb.Append("  dbRootPwd: ").Append(DbRootPwd).Append("\n");
            sb.Append("  feCount: ").Append(FeCount).Append("\n");
            sb.Append("  beCount: ").Append(BeCount).Append("\n");
            sb.Append("  azMode: ").Append(AzMode).Append("\n");
            sb.Append("  feVolume: ").Append(FeVolume).Append("\n");
            sb.Append("  beVolume: ").Append(BeVolume).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  tagsInfo: ").Append(TagsInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StarRocksCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StarRocksCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.Ha == input.Ha ||
                    (this.Ha != null &&
                    this.Ha.Equals(input.Ha))
                ) && 
                (
                    this.FeFlavorId == input.FeFlavorId ||
                    (this.FeFlavorId != null &&
                    this.FeFlavorId.Equals(input.FeFlavorId))
                ) && 
                (
                    this.BeFlavorId == input.BeFlavorId ||
                    (this.BeFlavorId != null &&
                    this.BeFlavorId.Equals(input.BeFlavorId))
                ) && 
                (
                    this.DbRootPwd == input.DbRootPwd ||
                    (this.DbRootPwd != null &&
                    this.DbRootPwd.Equals(input.DbRootPwd))
                ) && 
                (
                    this.FeCount == input.FeCount ||
                    (this.FeCount != null &&
                    this.FeCount.Equals(input.FeCount))
                ) && 
                (
                    this.BeCount == input.BeCount ||
                    (this.BeCount != null &&
                    this.BeCount.Equals(input.BeCount))
                ) && 
                (
                    this.AzMode == input.AzMode ||
                    (this.AzMode != null &&
                    this.AzMode.Equals(input.AzMode))
                ) && 
                (
                    this.FeVolume == input.FeVolume ||
                    (this.FeVolume != null &&
                    this.FeVolume.Equals(input.FeVolume))
                ) && 
                (
                    this.BeVolume == input.BeVolume ||
                    (this.BeVolume != null &&
                    this.BeVolume.Equals(input.BeVolume))
                ) && 
                (
                    this.AzCode == input.AzCode ||
                    (this.AzCode != null &&
                    this.AzCode.Equals(input.AzCode))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.TagsInfo == input.TagsInfo ||
                    (this.TagsInfo != null &&
                    this.TagsInfo.Equals(input.TagsInfo))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Ha != null)
                    hashCode = hashCode * 59 + this.Ha.GetHashCode();
                if (this.FeFlavorId != null)
                    hashCode = hashCode * 59 + this.FeFlavorId.GetHashCode();
                if (this.BeFlavorId != null)
                    hashCode = hashCode * 59 + this.BeFlavorId.GetHashCode();
                if (this.DbRootPwd != null)
                    hashCode = hashCode * 59 + this.DbRootPwd.GetHashCode();
                if (this.FeCount != null)
                    hashCode = hashCode * 59 + this.FeCount.GetHashCode();
                if (this.BeCount != null)
                    hashCode = hashCode * 59 + this.BeCount.GetHashCode();
                if (this.AzMode != null)
                    hashCode = hashCode * 59 + this.AzMode.GetHashCode();
                if (this.FeVolume != null)
                    hashCode = hashCode * 59 + this.FeVolume.GetHashCode();
                if (this.BeVolume != null)
                    hashCode = hashCode * 59 + this.BeVolume.GetHashCode();
                if (this.AzCode != null)
                    hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TagsInfo != null)
                    hashCode = hashCode * 59 + this.TagsInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
