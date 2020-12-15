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
    public class DeleteClusterRequest 
    {
        /// <summary>
        /// Defines deleteEfs
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DeleteEfsEnum>))]
        public class DeleteEfsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteEfsEnum TRUE = new DeleteEfsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteEfsEnum BLOCK = new DeleteEfsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteEfsEnum TRY = new DeleteEfsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteEfsEnum FALSE = new DeleteEfsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteEfsEnum SKIP = new DeleteEfsEnum("skip");

            private static readonly Dictionary<string, DeleteEfsEnum> StaticFields =
            new Dictionary<string, DeleteEfsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string Value;

            public DeleteEfsEnum(string value)
            {
                Value = value;
            }

            public static DeleteEfsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteEfsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteEfsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeleteEfsEnum a, DeleteEfsEnum b)
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

            public static bool operator !=(DeleteEfsEnum a, DeleteEfsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines deleteEni
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DeleteEniEnum>))]
        public class DeleteEniEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteEniEnum TRUE = new DeleteEniEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteEniEnum BLOCK = new DeleteEniEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteEniEnum TRY = new DeleteEniEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteEniEnum FALSE = new DeleteEniEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteEniEnum SKIP = new DeleteEniEnum("skip");

            private static readonly Dictionary<string, DeleteEniEnum> StaticFields =
            new Dictionary<string, DeleteEniEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string Value;

            public DeleteEniEnum(string value)
            {
                Value = value;
            }

            public static DeleteEniEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteEniEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteEniEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeleteEniEnum a, DeleteEniEnum b)
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

            public static bool operator !=(DeleteEniEnum a, DeleteEniEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines deleteEvs
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DeleteEvsEnum>))]
        public class DeleteEvsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteEvsEnum TRUE = new DeleteEvsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteEvsEnum BLOCK = new DeleteEvsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteEvsEnum TRY = new DeleteEvsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteEvsEnum FALSE = new DeleteEvsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteEvsEnum SKIP = new DeleteEvsEnum("skip");

            private static readonly Dictionary<string, DeleteEvsEnum> StaticFields =
            new Dictionary<string, DeleteEvsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string Value;

            public DeleteEvsEnum(string value)
            {
                Value = value;
            }

            public static DeleteEvsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteEvsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteEvsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeleteEvsEnum a, DeleteEvsEnum b)
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

            public static bool operator !=(DeleteEvsEnum a, DeleteEvsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines deleteNet
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DeleteNetEnum>))]
        public class DeleteNetEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteNetEnum TRUE = new DeleteNetEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteNetEnum BLOCK = new DeleteNetEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteNetEnum TRY = new DeleteNetEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteNetEnum FALSE = new DeleteNetEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteNetEnum SKIP = new DeleteNetEnum("skip");

            private static readonly Dictionary<string, DeleteNetEnum> StaticFields =
            new Dictionary<string, DeleteNetEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string Value;

            public DeleteNetEnum(string value)
            {
                Value = value;
            }

            public static DeleteNetEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteNetEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteNetEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeleteNetEnum a, DeleteNetEnum b)
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

            public static bool operator !=(DeleteNetEnum a, DeleteNetEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines deleteObs
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DeleteObsEnum>))]
        public class DeleteObsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteObsEnum TRUE = new DeleteObsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteObsEnum BLOCK = new DeleteObsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteObsEnum TRY = new DeleteObsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteObsEnum FALSE = new DeleteObsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteObsEnum SKIP = new DeleteObsEnum("skip");

            private static readonly Dictionary<string, DeleteObsEnum> StaticFields =
            new Dictionary<string, DeleteObsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string Value;

            public DeleteObsEnum(string value)
            {
                Value = value;
            }

            public static DeleteObsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteObsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteObsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeleteObsEnum a, DeleteObsEnum b)
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

            public static bool operator !=(DeleteObsEnum a, DeleteObsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines deleteSfs
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DeleteSfsEnum>))]
        public class DeleteSfsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteSfsEnum TRUE = new DeleteSfsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteSfsEnum BLOCK = new DeleteSfsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteSfsEnum TRY = new DeleteSfsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteSfsEnum FALSE = new DeleteSfsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteSfsEnum SKIP = new DeleteSfsEnum("skip");

            private static readonly Dictionary<string, DeleteSfsEnum> StaticFields =
            new Dictionary<string, DeleteSfsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string Value;

            public DeleteSfsEnum(string value)
            {
                Value = value;
            }

            public static DeleteSfsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteSfsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteSfsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DeleteSfsEnum a, DeleteSfsEnum b)
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

            public static bool operator !=(DeleteSfsEnum a, DeleteSfsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("errorStatus", IsQuery = true)]
        [JsonProperty("errorStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("delete_efs", IsQuery = true)]
        [JsonProperty("delete_efs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteEfsEnum DeleteEfs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("delete_eni", IsQuery = true)]
        [JsonProperty("delete_eni", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteEniEnum DeleteEni { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("delete_evs", IsQuery = true)]
        [JsonProperty("delete_evs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteEvsEnum DeleteEvs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("delete_net", IsQuery = true)]
        [JsonProperty("delete_net", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteNetEnum DeleteNet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("delete_obs", IsQuery = true)]
        [JsonProperty("delete_obs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteObsEnum DeleteObs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("delete_sfs", IsQuery = true)]
        [JsonProperty("delete_sfs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteSfsEnum DeleteSfs { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteClusterRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  errorStatus: ").Append(ErrorStatus).Append("\n");
            sb.Append("  deleteEfs: ").Append(DeleteEfs).Append("\n");
            sb.Append("  deleteEni: ").Append(DeleteEni).Append("\n");
            sb.Append("  deleteEvs: ").Append(DeleteEvs).Append("\n");
            sb.Append("  deleteNet: ").Append(DeleteNet).Append("\n");
            sb.Append("  deleteObs: ").Append(DeleteObs).Append("\n");
            sb.Append("  deleteSfs: ").Append(DeleteSfs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteClusterRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteClusterRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ErrorStatus == input.ErrorStatus ||
                    (this.ErrorStatus != null &&
                    this.ErrorStatus.Equals(input.ErrorStatus))
                ) && 
                (
                    this.DeleteEfs == input.DeleteEfs ||
                    (this.DeleteEfs != null &&
                    this.DeleteEfs.Equals(input.DeleteEfs))
                ) && 
                (
                    this.DeleteEni == input.DeleteEni ||
                    (this.DeleteEni != null &&
                    this.DeleteEni.Equals(input.DeleteEni))
                ) && 
                (
                    this.DeleteEvs == input.DeleteEvs ||
                    (this.DeleteEvs != null &&
                    this.DeleteEvs.Equals(input.DeleteEvs))
                ) && 
                (
                    this.DeleteNet == input.DeleteNet ||
                    (this.DeleteNet != null &&
                    this.DeleteNet.Equals(input.DeleteNet))
                ) && 
                (
                    this.DeleteObs == input.DeleteObs ||
                    (this.DeleteObs != null &&
                    this.DeleteObs.Equals(input.DeleteObs))
                ) && 
                (
                    this.DeleteSfs == input.DeleteSfs ||
                    (this.DeleteSfs != null &&
                    this.DeleteSfs.Equals(input.DeleteSfs))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ErrorStatus != null)
                    hashCode = hashCode * 59 + this.ErrorStatus.GetHashCode();
                if (this.DeleteEfs != null)
                    hashCode = hashCode * 59 + this.DeleteEfs.GetHashCode();
                if (this.DeleteEni != null)
                    hashCode = hashCode * 59 + this.DeleteEni.GetHashCode();
                if (this.DeleteEvs != null)
                    hashCode = hashCode * 59 + this.DeleteEvs.GetHashCode();
                if (this.DeleteNet != null)
                    hashCode = hashCode * 59 + this.DeleteNet.GetHashCode();
                if (this.DeleteObs != null)
                    hashCode = hashCode * 59 + this.DeleteObs.GetHashCode();
                if (this.DeleteSfs != null)
                    hashCode = hashCode * 59 + this.DeleteSfs.GetHashCode();
                return hashCode;
            }
        }
    }
}
