using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowParameterGroupDetailResponse : SdkResponse
    {
        /// <summary>
        /// 实例部署形态。independent：独立；ha：主备。
        /// </summary>
        /// <value>实例部署形态。independent：独立；ha：主备。</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceModeEnum>))]
        public class InstanceModeEnum
        {
            /// <summary>
            /// Enum INDEPENDENT for value: independent
            /// </summary>
            public static readonly InstanceModeEnum INDEPENDENT = new InstanceModeEnum("independent");

            /// <summary>
            /// Enum HA for value: ha
            /// </summary>
            public static readonly InstanceModeEnum HA = new InstanceModeEnum("ha");

            private static readonly Dictionary<string, InstanceModeEnum> StaticFields =
            new Dictionary<string, InstanceModeEnum>()
            {
                { "independent", INDEPENDENT },
                { "ha", HA },
            };

            private string _value;

            public InstanceModeEnum()
            {

            }

            public InstanceModeEnum(string value)
            {
                _value = value;
            }

            public static InstanceModeEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceModeEnum a, InstanceModeEnum b)
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

            public static bool operator !=(InstanceModeEnum a, InstanceModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数模板ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数模板名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数模板描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 引擎版本。 [数据库版本。支持V2.0-2.3版本，取值为“V2.0-2.3”]。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 实例部署形态。independent：独立；ha：主备。
        /// </summary>
        [JsonProperty("instance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceModeEnum InstanceMode { get; set; }
        /// <summary>
        /// 创建时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 修改时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 参数详情。
        /// </summary>
        [JsonProperty("configuration_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<ParaGroupParameterResult> ConfigurationParameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowParameterGroupDetailResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  instanceMode: ").Append(InstanceMode).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  configurationParameters: ").Append(ConfigurationParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowParameterGroupDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowParameterGroupDetailResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.InstanceMode != input.InstanceMode) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.ConfigurationParameters != input.ConfigurationParameters || (this.ConfigurationParameters != null && input.ConfigurationParameters != null && !this.ConfigurationParameters.SequenceEqual(input.ConfigurationParameters))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceMode.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ConfigurationParameters != null) hashCode = hashCode * 59 + this.ConfigurationParameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
