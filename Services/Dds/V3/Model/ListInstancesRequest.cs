using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInstancesRequest 
    {
        /// <summary>
        /// Defines mode
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum SHARDING for value: Sharding
            /// </summary>
            public static readonly ModeEnum SHARDING = new ModeEnum("Sharding");

            /// <summary>
            /// Enum REPLICASET for value: ReplicaSet
            /// </summary>
            public static readonly ModeEnum REPLICASET = new ModeEnum("ReplicaSet");

            /// <summary>
            /// Enum SINGLE for value: Single
            /// </summary>
            public static readonly ModeEnum SINGLE = new ModeEnum("Single");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "Sharding", SHARDING },
                { "ReplicaSet", REPLICASET },
                { "Single", SINGLE },
            };

            private string Value;

            public ModeEnum(string value)
            {
                Value = value;
            }

            public static ModeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines datastoreType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DatastoreTypeEnum>))]
        public class DatastoreTypeEnum
        {
            /// <summary>
            /// Enum DDS_COMMUNITY for value: DDS-Community
            /// </summary>
            public static readonly DatastoreTypeEnum DDS_COMMUNITY = new DatastoreTypeEnum("DDS-Community");

            /// <summary>
            /// Enum DDS_ENHANCED for value: DDS-Enhanced
            /// </summary>
            public static readonly DatastoreTypeEnum DDS_ENHANCED = new DatastoreTypeEnum("DDS-Enhanced");

            private static readonly Dictionary<string, DatastoreTypeEnum> StaticFields =
            new Dictionary<string, DatastoreTypeEnum>()
            {
                { "DDS-Community", DDS_COMMUNITY },
                { "DDS-Enhanced", DDS_ENHANCED },
            };

            private string Value;

            public DatastoreTypeEnum(string value)
            {
                Value = value;
            }

            public static DatastoreTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as DatastoreTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DatastoreTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DatastoreTypeEnum a, DatastoreTypeEnum b)
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

            public static bool operator !=(DatastoreTypeEnum a, DatastoreTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("mode", IsQuery = true)]
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("datastore_type", IsQuery = true)]
        [JsonProperty("datastore_type", NullValueHandling = NullValueHandling.Ignore)]
        public DatastoreTypeEnum DatastoreType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("vpc_id", IsQuery = true)]
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("subnet_id", IsQuery = true)]
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  datastoreType: ").Append(DatastoreType).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesRequest input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.DatastoreType == input.DatastoreType ||
                    (this.DatastoreType != null &&
                    this.DatastoreType.Equals(input.DatastoreType))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.DatastoreType != null)
                    hashCode = hashCode * 59 + this.DatastoreType.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
