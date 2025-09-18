using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateBusinessModel 
    {
        /// <summary>
        /// 默认值为SKYWALKING。
        /// </summary>
        /// <value>默认值为SKYWALKING。</value>
        [JsonConverter(typeof(EnumClassConverter<CmdbDatasourceTypeEnum>))]
        public class CmdbDatasourceTypeEnum
        {
            /// <summary>
            /// Enum OTEL for value: OTEL
            /// </summary>
            public static readonly CmdbDatasourceTypeEnum OTEL = new CmdbDatasourceTypeEnum("OTEL");

            /// <summary>
            /// Enum SKYWALKING for value: SKYWALKING
            /// </summary>
            public static readonly CmdbDatasourceTypeEnum SKYWALKING = new CmdbDatasourceTypeEnum("SKYWALKING");

            private static readonly Dictionary<string, CmdbDatasourceTypeEnum> StaticFields =
            new Dictionary<string, CmdbDatasourceTypeEnum>()
            {
                { "OTEL", OTEL },
                { "SKYWALKING", SKYWALKING },
            };

            private string _value;

            public CmdbDatasourceTypeEnum()
            {

            }

            public CmdbDatasourceTypeEnum(string value)
            {
                _value = value;
            }

            public static CmdbDatasourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CmdbDatasourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CmdbDatasourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CmdbDatasourceTypeEnum a, CmdbDatasourceTypeEnum b)
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

            public static bool operator !=(CmdbDatasourceTypeEnum a, CmdbDatasourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 企业项目ID，默认值为“0”，表示默认项目的ID。
        /// </summary>
        [JsonProperty("eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsId { get; set; }

        /// <summary>
        /// CMDB树显示的名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("descp", NullValueHandling = NullValueHandling.Ignore)]
        public string Descp { get; set; }

        /// <summary>
        /// 默认值为SKYWALKING。
        /// </summary>
        [JsonProperty("cmdb_datasource_type", NullValueHandling = NullValueHandling.Ignore)]
        public CmdbDatasourceTypeEnum CmdbDatasourceType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBusinessModel {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  epsId: ").Append(EpsId).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  descp: ").Append(Descp).Append("\n");
            sb.Append("  cmdbDatasourceType: ").Append(CmdbDatasourceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBusinessModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBusinessModel input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EpsId != input.EpsId || (this.EpsId != null && !this.EpsId.Equals(input.EpsId))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Descp != input.Descp || (this.Descp != null && !this.Descp.Equals(input.Descp))) return false;
            if (this.CmdbDatasourceType != input.CmdbDatasourceType) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EpsId != null) hashCode = hashCode * 59 + this.EpsId.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Descp != null) hashCode = hashCode * 59 + this.Descp.GetHashCode();
                hashCode = hashCode * 59 + this.CmdbDatasourceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
