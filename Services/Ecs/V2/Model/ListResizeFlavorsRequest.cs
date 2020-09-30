using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListResizeFlavorsRequest 
    {
        /// <summary>
        /// Defines sortDir
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortDirEnum>))]
        public class SortDirEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly SortDirEnum ASC = new SortDirEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly SortDirEnum DESC = new SortDirEnum("desc");

            private static readonly Dictionary<string, SortDirEnum> StaticFields =
            new Dictionary<string, SortDirEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string Value;

            private SortDirEnum(string value)
            {
                this.Value = value;
            }

            public static SortDirEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as SortDirEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortDirEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(SortDirEnum a, SortDirEnum b)
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

            public static bool operator !=(SortDirEnum a, SortDirEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines sortKey
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum FLAVORID for value: flavorid
            /// </summary>
            public static readonly SortKeyEnum FLAVORID = new SortKeyEnum("flavorid");

            /// <summary>
            /// Enum SORT_KEY for value: sort_key
            /// </summary>
            public static readonly SortKeyEnum SORT_KEY = new SortKeyEnum("sort_key");

            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly SortKeyEnum NAME = new SortKeyEnum("name");

            /// <summary>
            /// Enum MEMORY_MB for value: memory_mb
            /// </summary>
            public static readonly SortKeyEnum MEMORY_MB = new SortKeyEnum("memory_mb");

            /// <summary>
            /// Enum VCPUS for value: vcpus
            /// </summary>
            public static readonly SortKeyEnum VCPUS = new SortKeyEnum("vcpus");

            /// <summary>
            /// Enum ROOT_GB for value: root_gb
            /// </summary>
            public static readonly SortKeyEnum ROOT_GB = new SortKeyEnum("root_gb");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "flavorid", FLAVORID },
                { "sort_key", SORT_KEY },
                { "name", NAME },
                { "memory_mb", MEMORY_MB },
                { "vcpus", VCPUS },
                { "root_gb", ROOT_GB },
            };

            private string Value;

            private SortKeyEnum(string value)
            {
                this.Value = value;
            }

            public static SortKeyEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
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

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("instance_uuid", IsQuery = true)]
        [JsonProperty("instance_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public SortDirEnum SortDir { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public SortKeyEnum SortKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("source_flavor_id", IsQuery = true)]
        [JsonProperty("source_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceFlavorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("source_flavor_name", IsQuery = true)]
        [JsonProperty("source_flavor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceFlavorName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResizeFlavorsRequest {\n");
            sb.Append("  instanceUuid: ").Append(InstanceUuid).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sourceFlavorId: ").Append(SourceFlavorId).Append("\n");
            sb.Append("  sourceFlavorName: ").Append(SourceFlavorName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResizeFlavorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResizeFlavorsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceUuid == input.InstanceUuid ||
                    (this.InstanceUuid != null &&
                    this.InstanceUuid.Equals(input.InstanceUuid))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.SortDir == input.SortDir ||
                    (this.SortDir != null &&
                    this.SortDir.Equals(input.SortDir))
                ) && 
                (
                    this.SortKey == input.SortKey ||
                    (this.SortKey != null &&
                    this.SortKey.Equals(input.SortKey))
                ) && 
                (
                    this.SourceFlavorId == input.SourceFlavorId ||
                    (this.SourceFlavorId != null &&
                    this.SourceFlavorId.Equals(input.SourceFlavorId))
                ) && 
                (
                    this.SourceFlavorName == input.SourceFlavorName ||
                    (this.SourceFlavorName != null &&
                    this.SourceFlavorName.Equals(input.SourceFlavorName))
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
                if (this.InstanceUuid != null)
                    hashCode = hashCode * 59 + this.InstanceUuid.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.SortDir != null)
                    hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.SortKey != null)
                    hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SourceFlavorId != null)
                    hashCode = hashCode * 59 + this.SourceFlavorId.GetHashCode();
                if (this.SourceFlavorName != null)
                    hashCode = hashCode * 59 + this.SourceFlavorName.GetHashCode();
                return hashCode;
            }
        }
    }
}
