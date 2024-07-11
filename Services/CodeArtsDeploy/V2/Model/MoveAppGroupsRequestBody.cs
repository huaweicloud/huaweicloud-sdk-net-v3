using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MoveAppGroupsRequestBody 
    {
        /// <summary>
        /// 移动方向，1为上移，-1为下移
        /// </summary>
        /// <value>移动方向，1为上移，-1为下移</value>
        [JsonConverter(typeof(EnumClassConverter<MovementEnum>))]
        public class MovementEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly MovementEnum NUMBER_1 = new MovementEnum(1);

            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            public static readonly MovementEnum NUMBER_MINUS_1 = new MovementEnum(-1);

            private static readonly Dictionary<int?, MovementEnum> StaticFields =
            new Dictionary<int?, MovementEnum>()
            {
                { 1, NUMBER_1 },
                { -1, NUMBER_MINUS_1 },
            };

            private int? _value;

            public MovementEnum()
            {

            }

            public MovementEnum(int? value)
            {
                _value = value;
            }

            public static MovementEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as MovementEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MovementEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MovementEnum a, MovementEnum b)
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

            public static bool operator !=(MovementEnum a, MovementEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 分组id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 移动方向，1为上移，-1为下移
        /// </summary>
        [JsonProperty("movement", NullValueHandling = NullValueHandling.Ignore)]
        public MovementEnum Movement { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoveAppGroupsRequestBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  movement: ").Append(Movement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MoveAppGroupsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MoveAppGroupsRequestBody input)
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
                    this.Movement == input.Movement ||
                    (this.Movement != null &&
                    this.Movement.Equals(input.Movement))
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
                if (this.Movement != null)
                    hashCode = hashCode * 59 + this.Movement.GetHashCode();
                return hashCode;
            }
        }
    }
}
