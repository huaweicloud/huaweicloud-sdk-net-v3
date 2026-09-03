using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AttachDesktopPoolUserResponse : SdkResponse
    {
        /// <summary>
        /// CREATING：桌面创建中；WAITING：动态池排队等待；EXCEEDED：静态池已达最大值；ASSIGNING：有空闲桌面，分配中；RESETTING 重置中。
        /// </summary>
        /// <value>CREATING：桌面创建中；WAITING：动态池排队等待；EXCEEDED：静态池已达最大值；ASSIGNING：有空闲桌面，分配中；RESETTING 重置中。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly TypeEnum CREATING = new TypeEnum("CREATING");

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly TypeEnum WAITING = new TypeEnum("WAITING");

            /// <summary>
            /// Enum EXCEEDED for value: EXCEEDED
            /// </summary>
            public static readonly TypeEnum EXCEEDED = new TypeEnum("EXCEEDED");

            /// <summary>
            /// Enum ASSIGNING for value: ASSIGNING
            /// </summary>
            public static readonly TypeEnum ASSIGNING = new TypeEnum("ASSIGNING");

            /// <summary>
            /// Enum RESETTING for value: RESETTING
            /// </summary>
            public static readonly TypeEnum RESETTING = new TypeEnum("RESETTING");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "CREATING", CREATING },
                { "WAITING", WAITING },
                { "EXCEEDED", EXCEEDED },
                { "ASSIGNING", ASSIGNING },
                { "RESETTING", RESETTING },
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
                if (ReferenceEquals(a, b))
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
        /// CREATING：桌面创建中；WAITING：动态池排队等待；EXCEEDED：静态池已达最大值；ASSIGNING：有空闲桌面，分配中；RESETTING 重置中。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachDesktopPoolUserResponse {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachDesktopPoolUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachDesktopPoolUserResponse input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
