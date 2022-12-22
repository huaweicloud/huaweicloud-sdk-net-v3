using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VersionInfo 
    {
        /// <summary>
        /// API版本ID。
        /// </summary>
        /// <value>API版本ID。</value>
        [JsonConverter(typeof(EnumClassConverter<IdEnum>))]
        public class IdEnum
        {
            /// <summary>
            /// Enum V1 for value: v1
            /// </summary>
            public static readonly IdEnum V1 = new IdEnum("v1");

            /// <summary>
            /// Enum V2 for value: v2
            /// </summary>
            public static readonly IdEnum V2 = new IdEnum("v2");

            private static readonly Dictionary<string, IdEnum> StaticFields =
            new Dictionary<string, IdEnum>()
            {
                { "v1", V1 },
                { "v2", V2 },
            };

            private string _value;

            public IdEnum()
            {

            }

            public IdEnum(string value)
            {
                _value = value;
            }

            public static IdEnum FromValue(string value)
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

                if (this.Equals(obj as IdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IdEnum a, IdEnum b)
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

            public static bool operator !=(IdEnum a, IdEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 版本状态，为如下3种：CURRENT：表示该版本为主推版本；SUPPORT：表示为老版本，但是现在还继续支持；DEPRECATED：表示为废弃版本，存在后续删除的可能。
        /// </summary>
        /// <value>版本状态，为如下3种：CURRENT：表示该版本为主推版本；SUPPORT：表示为老版本，但是现在还继续支持；DEPRECATED：表示为废弃版本，存在后续删除的可能。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CURRENT for value: CURRENT
            /// </summary>
            public static readonly StatusEnum CURRENT = new StatusEnum("CURRENT");

            /// <summary>
            /// Enum SUPPORT for value: SUPPORT
            /// </summary>
            public static readonly StatusEnum SUPPORT = new StatusEnum("SUPPORT");

            /// <summary>
            /// Enum DEPRECATED for value: DEPRECATED
            /// </summary>
            public static readonly StatusEnum DEPRECATED = new StatusEnum("DEPRECATED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CURRENT", CURRENT },
                { "SUPPORT", SUPPORT },
                { "DEPRECATED", DEPRECATED },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// API版本ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public IdEnum Id { get; set; }
        /// <summary>
        /// API的URL相关信息。
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Links> Links { get; set; }

        /// <summary>
        /// 该版本API支持的最小微版本号。
        /// </summary>
        [JsonProperty("min_version", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVersion { get; set; }

        /// <summary>
        /// 版本状态，为如下3种：CURRENT：表示该版本为主推版本；SUPPORT：表示为老版本，但是现在还继续支持；DEPRECATED：表示为废弃版本，存在后续删除的可能。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 版本发布时间，使用UTC时间。
        /// </summary>
        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Update { get; set; }

        /// <summary>
        /// 该版本API支持的最大微版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  minVersion: ").Append(MinVersion).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  update: ").Append(Update).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.MinVersion == input.MinVersion ||
                    (this.MinVersion != null &&
                    this.MinVersion.Equals(input.MinVersion))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Update == input.Update ||
                    (this.Update != null &&
                    this.Update.Equals(input.Update))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.MinVersion != null)
                    hashCode = hashCode * 59 + this.MinVersion.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Update != null)
                    hashCode = hashCode * 59 + this.Update.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
