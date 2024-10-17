using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateRocketMqMigrationTaskRequest 
    {
        /// <summary>
        /// true开启同名覆盖，会对已有的同名元数据的配置进行修改，false时当Topic或group已存在则会报错。
        /// </summary>
        /// <value>true开启同名覆盖，会对已有的同名元数据的配置进行修改，false时当Topic或group已存在则会报错。</value>
        [JsonConverter(typeof(EnumClassConverter<OverwriteEnum>))]
        public class OverwriteEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly OverwriteEnum TRUE = new OverwriteEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly OverwriteEnum FALSE = new OverwriteEnum("false");

            private static readonly Dictionary<string, OverwriteEnum> StaticFields =
            new Dictionary<string, OverwriteEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public OverwriteEnum()
            {

            }

            public OverwriteEnum(string value)
            {
                _value = value;
            }

            public static OverwriteEnum FromValue(string value)
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

                if (this.Equals(obj as OverwriteEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OverwriteEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OverwriteEnum a, OverwriteEnum b)
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

            public static bool operator !=(OverwriteEnum a, OverwriteEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移任务类型，分为自建RocketMQ上云(rocketmq)、自建RabbitMQ上云(rabbitToRocket)
        /// </summary>
        /// <value>迁移任务类型，分为自建RocketMQ上云(rocketmq)、自建RabbitMQ上云(rabbitToRocket)</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ROCKETMQ for value: rocketmq
            /// </summary>
            public static readonly TypeEnum ROCKETMQ = new TypeEnum("rocketmq");

            /// <summary>
            /// Enum RABBITTOROCKET for value: rabbitToRocket
            /// </summary>
            public static readonly TypeEnum RABBITTOROCKET = new TypeEnum("rabbitToRocket");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "rocketmq", ROCKETMQ },
                { "rabbitToRocket", RABBITTOROCKET },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// true开启同名覆盖，会对已有的同名元数据的配置进行修改，false时当Topic或group已存在则会报错。
        /// </summary>
        [SDKProperty("overwrite", IsQuery = true)]
        [JsonProperty("overwrite", NullValueHandling = NullValueHandling.Ignore)]
        public OverwriteEnum Overwrite { get; set; }
        /// <summary>
        /// 迁移任务名称，名称规则参考创建实例。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 迁移任务类型，分为自建RocketMQ上云(rocketmq)、自建RabbitMQ上云(rabbitToRocket)
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateRocketMqMigrationTaskReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRocketMqMigrationTaskRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  overwrite: ").Append(Overwrite).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRocketMqMigrationTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRocketMqMigrationTaskRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Overwrite != input.Overwrite) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.Overwrite.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
