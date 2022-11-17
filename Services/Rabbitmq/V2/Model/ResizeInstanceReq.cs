using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResizeInstanceReq 
    {
        /// <summary>
        /// 规格变更后的规格ID。
        /// </summary>
        /// <value>规格变更后的规格ID。</value>
        [JsonConverter(typeof(EnumClassConverter<NewSpecCodeEnum>))]
        public class NewSpecCodeEnum
        {
            /// <summary>
            /// Enum DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_3 for value: dms.instance.rabbitmq.cluster.c3.4u8g.3
            /// </summary>
            public static readonly NewSpecCodeEnum DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_3 = new NewSpecCodeEnum("dms.instance.rabbitmq.cluster.c3.4u8g.3");

            /// <summary>
            /// Enum DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_5 for value: dms.instance.rabbitmq.cluster.c3.4u8g.5
            /// </summary>
            public static readonly NewSpecCodeEnum DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_5 = new NewSpecCodeEnum("dms.instance.rabbitmq.cluster.c3.4u8g.5");

            /// <summary>
            /// Enum DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_7 for value: dms.instance.rabbitmq.cluster.c3.4u8g.7
            /// </summary>
            public static readonly NewSpecCodeEnum DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_7 = new NewSpecCodeEnum("dms.instance.rabbitmq.cluster.c3.4u8g.7");

            private static readonly Dictionary<string, NewSpecCodeEnum> StaticFields =
            new Dictionary<string, NewSpecCodeEnum>()
            {
                { "dms.instance.rabbitmq.cluster.c3.4u8g.3", DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_3 },
                { "dms.instance.rabbitmq.cluster.c3.4u8g.5", DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_5 },
                { "dms.instance.rabbitmq.cluster.c3.4u8g.7", DMS_INSTANCE_RABBITMQ_CLUSTER_C3_4U8G_7 },
            };

            private string Value;

            public NewSpecCodeEnum(string value)
            {
                Value = value;
            }

            public static NewSpecCodeEnum FromValue(string value)
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

                if (this.Equals(obj as NewSpecCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NewSpecCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NewSpecCodeEnum a, NewSpecCodeEnum b)
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

            public static bool operator !=(NewSpecCodeEnum a, NewSpecCodeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 规格变更后的规格ID。
        /// </summary>
        [JsonProperty("new_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public NewSpecCodeEnum NewSpecCode { get; set; }
        /// <summary>
        /// 规格变更后的消息存储空间，单位：GB。
        /// </summary>
        [JsonProperty("new_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStorageSpace { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeInstanceReq {\n");
            sb.Append("  newSpecCode: ").Append(NewSpecCode).Append("\n");
            sb.Append("  newStorageSpace: ").Append(NewStorageSpace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeInstanceReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewSpecCode == input.NewSpecCode ||
                    (this.NewSpecCode != null &&
                    this.NewSpecCode.Equals(input.NewSpecCode))
                ) && 
                (
                    this.NewStorageSpace == input.NewStorageSpace ||
                    (this.NewStorageSpace != null &&
                    this.NewStorageSpace.Equals(input.NewStorageSpace))
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
                if (this.NewSpecCode != null)
                    hashCode = hashCode * 59 + this.NewSpecCode.GetHashCode();
                if (this.NewStorageSpace != null)
                    hashCode = hashCode * 59 + this.NewStorageSpace.GetHashCode();
                return hashCode;
            }
        }
    }
}
