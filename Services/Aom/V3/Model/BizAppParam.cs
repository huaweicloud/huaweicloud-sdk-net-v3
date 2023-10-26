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
    /// 
    /// </summary>
    public class BizAppParam 
    {
        /// <summary>
        /// 前端默认是CONSOLE，不需要传参。rest接口无参数是API，有参数只能是：SERVICE_DISCOVERY。创建应用必填，修改应用非必填
        /// </summary>
        /// <value>前端默认是CONSOLE，不需要传参。rest接口无参数是API，有参数只能是：SERVICE_DISCOVERY。创建应用必填，修改应用非必填</value>
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
        /// 描述：最大255字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 显示名：字符集长度2-64，仅支持字符集：中文字符、英文字母、数字、下划线、中划线、点
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 应用关联的企业项目id。企业级用户必传
        /// </summary>
        [JsonProperty("eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsId { get; set; }

        /// <summary>
        /// 名称：字符集长度2-64，仅支持字符集：英文字母、数字、下划线、中划线、点
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 前端默认是CONSOLE，不需要传参。rest接口无参数是API，有参数只能是：SERVICE_DISCOVERY。创建应用必填，修改应用非必填
        /// </summary>
        [JsonProperty("register_type", NullValueHandling = NullValueHandling.Ignore)]
        public RegisterTypeEnum RegisterType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BizAppParam {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  epsId: ").Append(EpsId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  registerType: ").Append(RegisterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BizAppParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BizAppParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.EpsId == input.EpsId ||
                    (this.EpsId != null &&
                    this.EpsId.Equals(input.EpsId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RegisterType == input.RegisterType ||
                    (this.RegisterType != null &&
                    this.RegisterType.Equals(input.RegisterType))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.EpsId != null)
                    hashCode = hashCode * 59 + this.EpsId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegisterType != null)
                    hashCode = hashCode * 59 + this.RegisterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
