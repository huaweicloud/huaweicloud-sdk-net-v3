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
    /// Request Object
    /// </summary>
    public class DeleteScalingInstanceRequest 
    {
        /// <summary>
        /// Defines instanceDelete
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<InstanceDeleteEnum>))]
        public class InstanceDeleteEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly InstanceDeleteEnum YES = new InstanceDeleteEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly InstanceDeleteEnum NO = new InstanceDeleteEnum("no");

            public static readonly Dictionary<string, InstanceDeleteEnum> StaticFields =
            new Dictionary<string, InstanceDeleteEnum>()
            {
                {"yes", YES},
                {"no", NO},
            };

            private string Value;

            public InstanceDeleteEnum(string Value)
            {
                this.Value = Value;
            }

            public static InstanceDeleteEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
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

                if (this.Equals(obj as InstanceDeleteEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceDeleteEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(InstanceDeleteEnum a, InstanceDeleteEnum b)
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

            public static bool operator !=(InstanceDeleteEnum a, InstanceDeleteEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("instance_delete", IsQuery = true)]
        public InstanceDeleteEnum InstanceDelete { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteScalingInstanceRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceDelete: ").Append(InstanceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteScalingInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteScalingInstanceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceDelete == input.InstanceDelete ||
                    (this.InstanceDelete != null &&
                    this.InstanceDelete.Equals(input.InstanceDelete))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceDelete != null)
                    hashCode = hashCode * 59 + this.InstanceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
