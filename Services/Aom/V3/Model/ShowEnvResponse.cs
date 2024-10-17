using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowEnvResponse : SdkResponse
    {
        /// <summary>
        /// 注册方式
        /// </summary>
        /// <value>注册方式</value>
        [JsonConverter(typeof(EnumClassConverter<RegisterTypeEnum>))]
        public class RegisterTypeEnum
        {
            /// <summary>
            /// Enum API for value: API
            /// </summary>
            public static readonly RegisterTypeEnum API = new RegisterTypeEnum("API");

            /// <summary>
            /// Enum CONSOLE for value: CONSOLE
            /// </summary>
            public static readonly RegisterTypeEnum CONSOLE = new RegisterTypeEnum("CONSOLE");

            /// <summary>
            /// Enum SERVICE_DISCOVERY for value: SERVICE_DISCOVERY
            /// </summary>
            public static readonly RegisterTypeEnum SERVICE_DISCOVERY = new RegisterTypeEnum("SERVICE_DISCOVERY");

            private static readonly Dictionary<string, RegisterTypeEnum> StaticFields =
            new Dictionary<string, RegisterTypeEnum>()
            {
                { "API", API },
                { "CONSOLE", CONSOLE },
                { "SERVICE_DISCOVERY", SERVICE_DISCOVERY },
            };

            private string _value;

            public RegisterTypeEnum()
            {

            }

            public RegisterTypeEnum(string value)
            {
                _value = value;
            }

            public static RegisterTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RegisterTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RegisterTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RegisterTypeEnum a, RegisterTypeEnum b)
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

            public static bool operator !=(RegisterTypeEnum a, RegisterTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// aomId
        /// </summary>
        [JsonProperty("aom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AomId { get; set; }

        /// <summary>
        /// 组件Id
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 环境Id
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvId { get; set; }

        /// <summary>
        /// 环境名称
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// 环境标签
        /// </summary>
        [JsonProperty("env_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagNameAndIdVo> EnvTags { get; set; }

        /// <summary>
        /// 环境类型
        /// </summary>
        [JsonProperty("env_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvType { get; set; }

        /// <summary>
        /// 企业项目Id
        /// </summary>
        [JsonProperty("eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [JsonProperty("modifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Modifier { get; set; }

        /// <summary>
        /// os类型
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 注册方式
        /// </summary>
        [JsonProperty("register_type", NullValueHandling = NullValueHandling.Ignore)]
        public RegisterTypeEnum RegisterType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEnvResponse {\n");
            sb.Append("  aomId: ").Append(AomId).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  envTags: ").Append(EnvTags).Append("\n");
            sb.Append("  envType: ").Append(EnvType).Append("\n");
            sb.Append("  epsId: ").Append(EpsId).Append("\n");
            sb.Append("  modifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  modifier: ").Append(Modifier).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  registerType: ").Append(RegisterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEnvResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEnvResponse input)
        {
            if (input == null) return false;
            if (this.AomId != input.AomId || (this.AomId != null && !this.AomId.Equals(input.AomId))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.EnvName != input.EnvName || (this.EnvName != null && !this.EnvName.Equals(input.EnvName))) return false;
            if (this.EnvTags != input.EnvTags || (this.EnvTags != null && input.EnvTags != null && !this.EnvTags.SequenceEqual(input.EnvTags))) return false;
            if (this.EnvType != input.EnvType || (this.EnvType != null && !this.EnvType.Equals(input.EnvType))) return false;
            if (this.EpsId != input.EpsId || (this.EpsId != null && !this.EpsId.Equals(input.EpsId))) return false;
            if (this.ModifiedTime != input.ModifiedTime || (this.ModifiedTime != null && !this.ModifiedTime.Equals(input.ModifiedTime))) return false;
            if (this.Modifier != input.Modifier || (this.Modifier != null && !this.Modifier.Equals(input.Modifier))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RegisterType != input.RegisterType) return false;

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
                if (this.AomId != null) hashCode = hashCode * 59 + this.AomId.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.EnvName != null) hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.EnvTags != null) hashCode = hashCode * 59 + this.EnvTags.GetHashCode();
                if (this.EnvType != null) hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.EpsId != null) hashCode = hashCode * 59 + this.EpsId.GetHashCode();
                if (this.ModifiedTime != null) hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.Modifier != null) hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                hashCode = hashCode * 59 + this.RegisterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
