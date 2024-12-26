using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IpsRuleVO 
    {
        /// <summary>
        /// Defines defaultStatus
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DefaultStatusEnum>))]
        public class DefaultStatusEnum
        {
            /// <summary>
            /// Enum OBSERVE for value: OBSERVE
            /// </summary>
            public static readonly DefaultStatusEnum OBSERVE = new DefaultStatusEnum("OBSERVE");

            /// <summary>
            /// Enum ENABLE for value: ENABLE
            /// </summary>
            public static readonly DefaultStatusEnum ENABLE = new DefaultStatusEnum("ENABLE");

            /// <summary>
            /// Enum CLOSE for value: CLOSE
            /// </summary>
            public static readonly DefaultStatusEnum CLOSE = new DefaultStatusEnum("CLOSE");

            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly DefaultStatusEnum DEFAULT = new DefaultStatusEnum("DEFAULT");

            /// <summary>
            /// Enum ALL_DEFAULT for value: ALL_DEFAULT
            /// </summary>
            public static readonly DefaultStatusEnum ALL_DEFAULT = new DefaultStatusEnum("ALL_DEFAULT");

            private static readonly Dictionary<string, DefaultStatusEnum> StaticFields =
            new Dictionary<string, DefaultStatusEnum>()
            {
                { "OBSERVE", OBSERVE },
                { "ENABLE", ENABLE },
                { "CLOSE", CLOSE },
                { "DEFAULT", DEFAULT },
                { "ALL_DEFAULT", ALL_DEFAULT },
            };

            private string _value;

            public DefaultStatusEnum()
            {

            }

            public DefaultStatusEnum(string value)
            {
                _value = value;
            }

            public static DefaultStatusEnum FromValue(string value)
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

                if (this.Equals(obj as DefaultStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DefaultStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DefaultStatusEnum a, DefaultStatusEnum b)
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

            public static bool operator !=(DefaultStatusEnum a, DefaultStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines ipsGroup
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<IpsGroupEnum>))]
        public class IpsGroupEnum
        {
            /// <summary>
            /// Enum OBSERVE for value: OBSERVE
            /// </summary>
            public static readonly IpsGroupEnum OBSERVE = new IpsGroupEnum("OBSERVE");

            /// <summary>
            /// Enum STRICTLY for value: STRICTLY
            /// </summary>
            public static readonly IpsGroupEnum STRICTLY = new IpsGroupEnum("STRICTLY");

            /// <summary>
            /// Enum MEDIUM for value: MEDIUM
            /// </summary>
            public static readonly IpsGroupEnum MEDIUM = new IpsGroupEnum("MEDIUM");

            /// <summary>
            /// Enum LOW for value: LOW
            /// </summary>
            public static readonly IpsGroupEnum LOW = new IpsGroupEnum("LOW");

            private static readonly Dictionary<string, IpsGroupEnum> StaticFields =
            new Dictionary<string, IpsGroupEnum>()
            {
                { "OBSERVE", OBSERVE },
                { "STRICTLY", STRICTLY },
                { "MEDIUM", MEDIUM },
                { "LOW", LOW },
            };

            private string _value;

            public IpsGroupEnum()
            {

            }

            public IpsGroupEnum(string value)
            {
                _value = value;
            }

            public static IpsGroupEnum FromValue(string value)
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

                if (this.Equals(obj as IpsGroupEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpsGroupEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpsGroupEnum a, IpsGroupEnum b)
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

            public static bool operator !=(IpsGroupEnum a, IpsGroupEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines ipsLevel
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<IpsLevelEnum>))]
        public class IpsLevelEnum
        {
            /// <summary>
            /// Enum FATAL for value: FATAL
            /// </summary>
            public static readonly IpsLevelEnum FATAL = new IpsLevelEnum("FATAL");

            /// <summary>
            /// Enum HIGH for value: HIGH
            /// </summary>
            public static readonly IpsLevelEnum HIGH = new IpsLevelEnum("HIGH");

            /// <summary>
            /// Enum MEDIUM for value: MEDIUM
            /// </summary>
            public static readonly IpsLevelEnum MEDIUM = new IpsLevelEnum("MEDIUM");

            /// <summary>
            /// Enum LOW for value: LOW
            /// </summary>
            public static readonly IpsLevelEnum LOW = new IpsLevelEnum("LOW");

            /// <summary>
            /// Enum UNKNOWNS for value: UNKNOWNS
            /// </summary>
            public static readonly IpsLevelEnum UNKNOWNS = new IpsLevelEnum("UNKNOWNS");

            private static readonly Dictionary<string, IpsLevelEnum> StaticFields =
            new Dictionary<string, IpsLevelEnum>()
            {
                { "FATAL", FATAL },
                { "HIGH", HIGH },
                { "MEDIUM", MEDIUM },
                { "LOW", LOW },
                { "UNKNOWNS", UNKNOWNS },
            };

            private string _value;

            public IpsLevelEnum()
            {

            }

            public IpsLevelEnum(string value)
            {
                _value = value;
            }

            public static IpsLevelEnum FromValue(string value)
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

                if (this.Equals(obj as IpsLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpsLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpsLevelEnum a, IpsLevelEnum b)
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

            public static bool operator !=(IpsLevelEnum a, IpsLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines ipsStatus
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<IpsStatusEnum>))]
        public class IpsStatusEnum
        {
            /// <summary>
            /// Enum OBSERVE for value: OBSERVE
            /// </summary>
            public static readonly IpsStatusEnum OBSERVE = new IpsStatusEnum("OBSERVE");

            /// <summary>
            /// Enum ENABLE for value: ENABLE
            /// </summary>
            public static readonly IpsStatusEnum ENABLE = new IpsStatusEnum("ENABLE");

            /// <summary>
            /// Enum CLOSE for value: CLOSE
            /// </summary>
            public static readonly IpsStatusEnum CLOSE = new IpsStatusEnum("CLOSE");

            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly IpsStatusEnum DEFAULT = new IpsStatusEnum("DEFAULT");

            /// <summary>
            /// Enum ALL_DEFAULT for value: ALL_DEFAULT
            /// </summary>
            public static readonly IpsStatusEnum ALL_DEFAULT = new IpsStatusEnum("ALL_DEFAULT");

            private static readonly Dictionary<string, IpsStatusEnum> StaticFields =
            new Dictionary<string, IpsStatusEnum>()
            {
                { "OBSERVE", OBSERVE },
                { "ENABLE", ENABLE },
                { "CLOSE", CLOSE },
                { "DEFAULT", DEFAULT },
                { "ALL_DEFAULT", ALL_DEFAULT },
            };

            private string _value;

            public IpsStatusEnum()
            {

            }

            public IpsStatusEnum(string value)
            {
                _value = value;
            }

            public static IpsStatusEnum FromValue(string value)
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

                if (this.Equals(obj as IpsStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpsStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpsStatusEnum a, IpsStatusEnum b)
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

            public static bool operator !=(IpsStatusEnum a, IpsStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("affected_application", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedApplication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_status", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultStatusEnum DefaultStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ips_cve", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsCve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ips_group", NullValueHandling = NullValueHandling.Ignore)]
        public IpsGroupEnum IpsGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ips_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ips_level", NullValueHandling = NullValueHandling.Ignore)]
        public IpsLevelEnum IpsLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ips_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ips_rules_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsRulesType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ips_status", NullValueHandling = NullValueHandling.Ignore)]
        public IpsStatusEnum IpsStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsRuleVO {\n");
            sb.Append("  affectedApplication: ").Append(AffectedApplication).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  defaultStatus: ").Append(DefaultStatus).Append("\n");
            sb.Append("  ipsCve: ").Append(IpsCve).Append("\n");
            sb.Append("  ipsGroup: ").Append(IpsGroup).Append("\n");
            sb.Append("  ipsId: ").Append(IpsId).Append("\n");
            sb.Append("  ipsLevel: ").Append(IpsLevel).Append("\n");
            sb.Append("  ipsName: ").Append(IpsName).Append("\n");
            sb.Append("  ipsRulesType: ").Append(IpsRulesType).Append("\n");
            sb.Append("  ipsStatus: ").Append(IpsStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsRuleVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsRuleVO input)
        {
            if (input == null) return false;
            if (this.AffectedApplication != input.AffectedApplication || (this.AffectedApplication != null && !this.AffectedApplication.Equals(input.AffectedApplication))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.DefaultStatus != input.DefaultStatus) return false;
            if (this.IpsCve != input.IpsCve || (this.IpsCve != null && !this.IpsCve.Equals(input.IpsCve))) return false;
            if (this.IpsGroup != input.IpsGroup) return false;
            if (this.IpsId != input.IpsId || (this.IpsId != null && !this.IpsId.Equals(input.IpsId))) return false;
            if (this.IpsLevel != input.IpsLevel) return false;
            if (this.IpsName != input.IpsName || (this.IpsName != null && !this.IpsName.Equals(input.IpsName))) return false;
            if (this.IpsRulesType != input.IpsRulesType || (this.IpsRulesType != null && !this.IpsRulesType.Equals(input.IpsRulesType))) return false;
            if (this.IpsStatus != input.IpsStatus) return false;

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
                if (this.AffectedApplication != null) hashCode = hashCode * 59 + this.AffectedApplication.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultStatus.GetHashCode();
                if (this.IpsCve != null) hashCode = hashCode * 59 + this.IpsCve.GetHashCode();
                hashCode = hashCode * 59 + this.IpsGroup.GetHashCode();
                if (this.IpsId != null) hashCode = hashCode * 59 + this.IpsId.GetHashCode();
                hashCode = hashCode * 59 + this.IpsLevel.GetHashCode();
                if (this.IpsName != null) hashCode = hashCode * 59 + this.IpsName.GetHashCode();
                if (this.IpsRulesType != null) hashCode = hashCode * 59 + this.IpsRulesType.GetHashCode();
                hashCode = hashCode * 59 + this.IpsStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
