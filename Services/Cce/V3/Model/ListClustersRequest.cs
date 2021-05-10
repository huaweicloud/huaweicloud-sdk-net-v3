using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListClustersRequest 
    {
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: Available
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("Available");

            /// <summary>
            /// Enum UNAVAILABLE for value: Unavailable
            /// </summary>
            public static readonly StatusEnum UNAVAILABLE = new StatusEnum("Unavailable");

            /// <summary>
            /// Enum SCALINGUP for value: ScalingUp
            /// </summary>
            public static readonly StatusEnum SCALINGUP = new StatusEnum("ScalingUp");

            /// <summary>
            /// Enum SCALINGDOWN for value: ScalingDown
            /// </summary>
            public static readonly StatusEnum SCALINGDOWN = new StatusEnum("ScalingDown");

            /// <summary>
            /// Enum CREATING for value: Creating
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("Creating");

            /// <summary>
            /// Enum DELETING for value: Deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("Deleting");

            /// <summary>
            /// Enum UPGRADING for value: Upgrading
            /// </summary>
            public static readonly StatusEnum UPGRADING = new StatusEnum("Upgrading");

            /// <summary>
            /// Enum RESIZING for value: Resizing
            /// </summary>
            public static readonly StatusEnum RESIZING = new StatusEnum("Resizing");

            /// <summary>
            /// Enum EMPTY for value: Empty
            /// </summary>
            public static readonly StatusEnum EMPTY = new StatusEnum("Empty");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "Available", AVAILABLE },
                { "Unavailable", UNAVAILABLE },
                { "ScalingUp", SCALINGUP },
                { "ScalingDown", SCALINGDOWN },
                { "Creating", CREATING },
                { "Deleting", DELETING },
                { "Upgrading", UPGRADING },
                { "Resizing", RESIZING },
                { "Empty", EMPTY },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// Defines type
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VIRTUALMACHINE for value: VirtualMachine
            /// </summary>
            public static readonly TypeEnum VIRTUALMACHINE = new TypeEnum("VirtualMachine");

            /// <summary>
            /// Enum ARM64 for value: ARM64
            /// </summary>
            public static readonly TypeEnum ARM64 = new TypeEnum("ARM64");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "VirtualMachine", VIRTUALMACHINE },
                { "ARM64", ARM64 },
            };

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("errorStatus", IsQuery = true)]
        [JsonProperty("errorStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("detail", IsQuery = true)]
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("version", IsQuery = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListClustersRequest {\n");
            sb.Append("  errorStatus: ").Append(ErrorStatus).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListClustersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListClustersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorStatus == input.ErrorStatus ||
                    (this.ErrorStatus != null &&
                    this.ErrorStatus.Equals(input.ErrorStatus))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ErrorStatus != null)
                    hashCode = hashCode * 59 + this.ErrorStatus.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
