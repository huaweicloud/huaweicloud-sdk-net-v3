using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSinkTaskReq 
    {
        /// <summary>
        /// 源数据类型，目前只支持BLOB。 
        /// </summary>
        /// <value>源数据类型，目前只支持BLOB。 </value>
        [JsonConverter(typeof(EnumClassConverter<SourceTypeEnum>))]
        public class SourceTypeEnum
        {
            /// <summary>
            /// Enum BLOB for value: BLOB
            /// </summary>
            public static readonly SourceTypeEnum BLOB = new SourceTypeEnum("BLOB");

            private static readonly Dictionary<string, SourceTypeEnum> StaticFields =
            new Dictionary<string, SourceTypeEnum>()
            {
                { "BLOB", BLOB },
            };

            private string Value;

            public SourceTypeEnum(string value)
            {
                Value = value;
            }

            public static SourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(SourceTypeEnum a, SourceTypeEnum b)
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

            public static bool operator !=(SourceTypeEnum a, SourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 转存的目标类型，当前只支持OBS。 
        /// </summary>
        /// <value>转存的目标类型，当前只支持OBS。 </value>
        [JsonConverter(typeof(EnumClassConverter<DestinationTypeEnum>))]
        public class DestinationTypeEnum
        {
            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly DestinationTypeEnum OBS = new DestinationTypeEnum("OBS");

            private static readonly Dictionary<string, DestinationTypeEnum> StaticFields =
            new Dictionary<string, DestinationTypeEnum>()
            {
                { "OBS", OBS },
            };

            private string Value;

            public DestinationTypeEnum(string value)
            {
                Value = value;
            }

            public static DestinationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DestinationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DestinationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DestinationTypeEnum a, DestinationTypeEnum b)
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

            public static bool operator !=(DestinationTypeEnum a, DestinationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 源数据类型，目前只支持BLOB。 
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// 转储任务名称。 
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 转存的目标类型，当前只支持OBS。 
        /// </summary>
        [JsonProperty("destination_type", NullValueHandling = NullValueHandling.Ignore)]
        public DestinationTypeEnum DestinationType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_destination_descriptor", NullValueHandling = NullValueHandling.Ignore)]
        public ObsDestinationDescriptor ObsDestinationDescriptor { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSinkTaskReq {\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  destinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  obsDestinationDescriptor: ").Append(ObsDestinationDescriptor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSinkTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSinkTaskReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.ObsDestinationDescriptor == input.ObsDestinationDescriptor ||
                    (this.ObsDestinationDescriptor != null &&
                    this.ObsDestinationDescriptor.Equals(input.ObsDestinationDescriptor))
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
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.ObsDestinationDescriptor != null)
                    hashCode = hashCode * 59 + this.ObsDestinationDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }
}
