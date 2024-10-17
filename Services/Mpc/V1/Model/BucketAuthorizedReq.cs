using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BucketAuthorizedReq 
    {
        /// <summary>
        /// 操作标记，取值[0,1]，0表示取消授权，1表示授权 
        /// </summary>
        /// <value>操作标记，取值[0,1]，0表示取消授权，1表示授权 </value>
        [JsonConverter(typeof(EnumClassConverter<OperationEnum>))]
        public class OperationEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly OperationEnum _0 = new OperationEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly OperationEnum _1 = new OperationEnum("1");

            private static readonly Dictionary<string, OperationEnum> StaticFields =
            new Dictionary<string, OperationEnum>()
            {
                { "0", _0 },
                { "1", _1 },
            };

            private string _value;

            public OperationEnum()
            {

            }

            public OperationEnum(string value)
            {
                _value = value;
            }

            public static OperationEnum FromValue(string value)
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

                if (this.Equals(obj as OperationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationEnum a, OperationEnum b)
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

            public static bool operator !=(OperationEnum a, OperationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桶名 
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 操作标记，取值[0,1]，0表示取消授权，1表示授权 
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public OperationEnum Operation { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BucketAuthorizedReq {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BucketAuthorizedReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BucketAuthorizedReq input)
        {
            if (input == null) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.Operation != input.Operation) return false;

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
                if (this.Bucket != null) hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                hashCode = hashCode * 59 + this.Operation.GetHashCode();
                return hashCode;
            }
        }
    }
}
