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
    public class EnvParam 
    {
        /// <summary>
        /// 环境类型，取值：DEV、TEST、PRE、ONLINE，不区分大小写
        /// </summary>
        /// <value>环境类型，取值：DEV、TEST、PRE、ONLINE，不区分大小写</value>
        [JsonConverter(typeof(EnumClassConverter<EnvTypeEnum>))]
        public class EnvTypeEnum
        {
            /// <summary>
            /// Enum DEV for value: DEV
            /// </summary>
            public static readonly EnvTypeEnum DEV = new EnvTypeEnum("DEV");

            /// <summary>
            /// Enum TEST for value: TEST
            /// </summary>
            public static readonly EnvTypeEnum TEST = new EnvTypeEnum("TEST");

            /// <summary>
            /// Enum PRE for value: PRE
            /// </summary>
            public static readonly EnvTypeEnum PRE = new EnvTypeEnum("PRE");

            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            public static readonly EnvTypeEnum ONLINE = new EnvTypeEnum("ONLINE");

            private static readonly Dictionary<string, EnvTypeEnum> StaticFields =
            new Dictionary<string, EnvTypeEnum>()
            {
                { "DEV", DEV },
                { "TEST", TEST },
                { "PRE", PRE },
                { "ONLINE", ONLINE },
            };

            private string _value;

            public EnvTypeEnum()
            {

            }

            public EnvTypeEnum(string value)
            {
                _value = value;
            }

            public static EnvTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EnvTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EnvTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EnvTypeEnum a, EnvTypeEnum b)
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

            public static bool operator !=(EnvTypeEnum a, EnvTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// OS类型，取值：LINUX、WINDOWS。创建环境必传，不可修改
        /// </summary>
        /// <value>OS类型，取值：LINUX、WINDOWS。创建环境必传，不可修改</value>
        [JsonConverter(typeof(EnumClassConverter<OsTypeEnum>))]
        public class OsTypeEnum
        {
            /// <summary>
            /// Enum LINUX for value: LINUX
            /// </summary>
            public static readonly OsTypeEnum LINUX = new OsTypeEnum("LINUX");

            /// <summary>
            /// Enum WINDOWS for value: WINDOWS
            /// </summary>
            public static readonly OsTypeEnum WINDOWS = new OsTypeEnum("WINDOWS");

            private static readonly Dictionary<string, OsTypeEnum> StaticFields =
            new Dictionary<string, OsTypeEnum>()
            {
                { "LINUX", LINUX },
                { "WINDOWS", WINDOWS },
            };

            private string _value;

            public OsTypeEnum()
            {

            }

            public OsTypeEnum(string value)
            {
                _value = value;
            }

            public static OsTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OsTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsTypeEnum a, OsTypeEnum b)
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

            public static bool operator !=(OsTypeEnum a, OsTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 注册类型，取值：API、SERVICE_DISCOVERY、CONSOLE，默认值：API
        /// </summary>
        /// <value>注册类型，取值：API、SERVICE_DISCOVERY、CONSOLE，默认值：API</value>
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
        /// 环境关联组件id；id长度不能超过36位，由大小写字母、数字组成。创建环境必传，修改环境时非必选
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// 描述：最大255字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 显示名：字符集长度2-64，仅支持字符集：中文字符、英文字母、数字、下划线、中划线、点
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// 环境类型，取值：DEV、TEST、PRE、ONLINE，不区分大小写
        /// </summary>
        [JsonProperty("env_type", NullValueHandling = NullValueHandling.Ignore)]
        public EnvTypeEnum EnvType { get; set; }
        /// <summary>
        /// OS类型，取值：LINUX、WINDOWS。创建环境必传，不可修改
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        /// <summary>
        /// 环境关联region。创建环境必传，不可修改
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 注册类型，取值：API、SERVICE_DISCOVERY、CONSOLE，默认值：API
        /// </summary>
        [JsonProperty("register_type", NullValueHandling = NullValueHandling.Ignore)]
        public RegisterTypeEnum RegisterType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvParam {\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  envType: ").Append(EnvType).Append("\n");
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
            return this.Equals(input as EnvParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComponentId == input.ComponentId ||
                    (this.ComponentId != null &&
                    this.ComponentId.Equals(input.ComponentId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnvName == input.EnvName ||
                    (this.EnvName != null &&
                    this.EnvName.Equals(input.EnvName))
                ) && 
                (
                    this.EnvType == input.EnvType ||
                    (this.EnvType != null &&
                    this.EnvType.Equals(input.EnvType))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
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
                if (this.ComponentId != null)
                    hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnvName != null)
                    hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.EnvType != null)
                    hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RegisterType != null)
                    hashCode = hashCode * 59 + this.RegisterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
