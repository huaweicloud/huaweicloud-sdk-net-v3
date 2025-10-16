using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 项目属性。
    /// </summary>
    public class ArticlePropertiesResponse 
    {
        /// <summary>
        /// 插入交付格式。
        /// </summary>
        /// <value>插入交付格式。</value>
        [JsonConverter(typeof(EnumClassConverter<InsertDeliveryFormatEnum>))]
        public class InsertDeliveryFormatEnum
        {
            /// <summary>
            /// Enum DO_NOT_INSERT for value: do_not_insert
            /// </summary>
            public static readonly InsertDeliveryFormatEnum DO_NOT_INSERT = new InsertDeliveryFormatEnum("do_not_insert");

            /// <summary>
            /// Enum INSERT for value: insert
            /// </summary>
            public static readonly InsertDeliveryFormatEnum INSERT = new InsertDeliveryFormatEnum("insert");

            /// <summary>
            /// Enum INSERT_WITHOUT_COLUMN_LIST for value: insert_without_column_list
            /// </summary>
            public static readonly InsertDeliveryFormatEnum INSERT_WITHOUT_COLUMN_LIST = new InsertDeliveryFormatEnum("insert_without_column_list");

            /// <summary>
            /// Enum CALL_PROCEDURE for value: call_procedure
            /// </summary>
            public static readonly InsertDeliveryFormatEnum CALL_PROCEDURE = new InsertDeliveryFormatEnum("call_procedure");

            private static readonly Dictionary<string, InsertDeliveryFormatEnum> StaticFields =
            new Dictionary<string, InsertDeliveryFormatEnum>()
            {
                { "do_not_insert", DO_NOT_INSERT },
                { "insert", INSERT },
                { "insert_without_column_list", INSERT_WITHOUT_COLUMN_LIST },
                { "call_procedure", CALL_PROCEDURE },
            };

            private string _value;

            public InsertDeliveryFormatEnum()
            {

            }

            public InsertDeliveryFormatEnum(string value)
            {
                _value = value;
            }

            public static InsertDeliveryFormatEnum FromValue(string value)
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

                if (this.Equals(obj as InsertDeliveryFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InsertDeliveryFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InsertDeliveryFormatEnum a, InsertDeliveryFormatEnum b)
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

            public static bool operator !=(InsertDeliveryFormatEnum a, InsertDeliveryFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 更新交付格式。
        /// </summary>
        /// <value>更新交付格式。</value>
        [JsonConverter(typeof(EnumClassConverter<UpdateDeliveryFormatEnum>))]
        public class UpdateDeliveryFormatEnum
        {
            /// <summary>
            /// Enum DO_NOT_UPDATE for value: do_not_update
            /// </summary>
            public static readonly UpdateDeliveryFormatEnum DO_NOT_UPDATE = new UpdateDeliveryFormatEnum("do_not_update");

            /// <summary>
            /// Enum UPDATE for value: update
            /// </summary>
            public static readonly UpdateDeliveryFormatEnum UPDATE = new UpdateDeliveryFormatEnum("update");

            /// <summary>
            /// Enum CALL_PROCEDURE for value: call_procedure
            /// </summary>
            public static readonly UpdateDeliveryFormatEnum CALL_PROCEDURE = new UpdateDeliveryFormatEnum("call_procedure");

            /// <summary>
            /// Enum MCALL_PROCEDURE for value: mcall_procedure
            /// </summary>
            public static readonly UpdateDeliveryFormatEnum MCALL_PROCEDURE = new UpdateDeliveryFormatEnum("mcall_procedure");

            /// <summary>
            /// Enum XCALL_PROCEDURE for value: xcall_procedure
            /// </summary>
            public static readonly UpdateDeliveryFormatEnum XCALL_PROCEDURE = new UpdateDeliveryFormatEnum("xcall_procedure");

            /// <summary>
            /// Enum SCALL_PROCEDURE for value: scall_procedure
            /// </summary>
            public static readonly UpdateDeliveryFormatEnum SCALL_PROCEDURE = new UpdateDeliveryFormatEnum("scall_procedure");

            private static readonly Dictionary<string, UpdateDeliveryFormatEnum> StaticFields =
            new Dictionary<string, UpdateDeliveryFormatEnum>()
            {
                { "do_not_update", DO_NOT_UPDATE },
                { "update", UPDATE },
                { "call_procedure", CALL_PROCEDURE },
                { "mcall_procedure", MCALL_PROCEDURE },
                { "xcall_procedure", XCALL_PROCEDURE },
                { "scall_procedure", SCALL_PROCEDURE },
            };

            private string _value;

            public UpdateDeliveryFormatEnum()
            {

            }

            public UpdateDeliveryFormatEnum(string value)
            {
                _value = value;
            }

            public static UpdateDeliveryFormatEnum FromValue(string value)
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

                if (this.Equals(obj as UpdateDeliveryFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UpdateDeliveryFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UpdateDeliveryFormatEnum a, UpdateDeliveryFormatEnum b)
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

            public static bool operator !=(UpdateDeliveryFormatEnum a, UpdateDeliveryFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 删除交付格式。
        /// </summary>
        /// <value>删除交付格式。</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteDeliveryFormatEnum>))]
        public class DeleteDeliveryFormatEnum
        {
            /// <summary>
            /// Enum DO_NOT_DELETE for value: do_not_delete
            /// </summary>
            public static readonly DeleteDeliveryFormatEnum DO_NOT_DELETE = new DeleteDeliveryFormatEnum("do_not_delete");

            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly DeleteDeliveryFormatEnum DELETE = new DeleteDeliveryFormatEnum("delete");

            /// <summary>
            /// Enum CALL_PROCEDURE for value: call_procedure
            /// </summary>
            public static readonly DeleteDeliveryFormatEnum CALL_PROCEDURE = new DeleteDeliveryFormatEnum("call_procedure");

            /// <summary>
            /// Enum XCALL_PROCEDURE for value: xcall_procedure
            /// </summary>
            public static readonly DeleteDeliveryFormatEnum XCALL_PROCEDURE = new DeleteDeliveryFormatEnum("xcall_procedure");

            private static readonly Dictionary<string, DeleteDeliveryFormatEnum> StaticFields =
            new Dictionary<string, DeleteDeliveryFormatEnum>()
            {
                { "do_not_delete", DO_NOT_DELETE },
                { "delete", DELETE },
                { "call_procedure", CALL_PROCEDURE },
                { "xcall_procedure", XCALL_PROCEDURE },
            };

            private string _value;

            public DeleteDeliveryFormatEnum()
            {

            }

            public DeleteDeliveryFormatEnum(string value)
            {
                _value = value;
            }

            public static DeleteDeliveryFormatEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteDeliveryFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteDeliveryFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteDeliveryFormatEnum a, DeleteDeliveryFormatEnum b)
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

            public static bool operator !=(DeleteDeliveryFormatEnum a, DeleteDeliveryFormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 目标对象名称。
        /// </summary>
        [JsonProperty("destination_object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationObjectName { get; set; }

        /// <summary>
        /// 目标对象命名空间。
        /// </summary>
        [JsonProperty("destination_object_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationObjectOwner { get; set; }

        /// <summary>
        /// 插入交付格式。
        /// </summary>
        [JsonProperty("insert_delivery_format", NullValueHandling = NullValueHandling.Ignore)]
        public InsertDeliveryFormatEnum InsertDeliveryFormat { get; set; }
        /// <summary>
        /// 插入存储过程。插入交付格式填call_procedure时该项必填。
        /// </summary>
        [JsonProperty("insert_stored_procedure", NullValueHandling = NullValueHandling.Ignore)]
        public string InsertStoredProcedure { get; set; }

        /// <summary>
        /// 更新交付格式。
        /// </summary>
        [JsonProperty("update_delivery_format", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateDeliveryFormatEnum UpdateDeliveryFormat { get; set; }
        /// <summary>
        /// 更新存储过程。更新交付格式填(m/x/s)call_procedure时该项必填。
        /// </summary>
        [JsonProperty("update_stored_procedure", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateStoredProcedure { get; set; }

        /// <summary>
        /// 删除交付格式。
        /// </summary>
        [JsonProperty("delete_delivery_format", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteDeliveryFormatEnum DeleteDeliveryFormat { get; set; }
        /// <summary>
        /// 删除存储过程。删除交付格式填(x)call_procedure时该项必填。
        /// </summary>
        [JsonProperty("delete_stored_procedure", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteStoredProcedure { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArticlePropertiesResponse {\n");
            sb.Append("  destinationObjectName: ").Append(DestinationObjectName).Append("\n");
            sb.Append("  destinationObjectOwner: ").Append(DestinationObjectOwner).Append("\n");
            sb.Append("  insertDeliveryFormat: ").Append(InsertDeliveryFormat).Append("\n");
            sb.Append("  insertStoredProcedure: ").Append(InsertStoredProcedure).Append("\n");
            sb.Append("  updateDeliveryFormat: ").Append(UpdateDeliveryFormat).Append("\n");
            sb.Append("  updateStoredProcedure: ").Append(UpdateStoredProcedure).Append("\n");
            sb.Append("  deleteDeliveryFormat: ").Append(DeleteDeliveryFormat).Append("\n");
            sb.Append("  deleteStoredProcedure: ").Append(DeleteStoredProcedure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArticlePropertiesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ArticlePropertiesResponse input)
        {
            if (input == null) return false;
            if (this.DestinationObjectName != input.DestinationObjectName || (this.DestinationObjectName != null && !this.DestinationObjectName.Equals(input.DestinationObjectName))) return false;
            if (this.DestinationObjectOwner != input.DestinationObjectOwner || (this.DestinationObjectOwner != null && !this.DestinationObjectOwner.Equals(input.DestinationObjectOwner))) return false;
            if (this.InsertDeliveryFormat != input.InsertDeliveryFormat) return false;
            if (this.InsertStoredProcedure != input.InsertStoredProcedure || (this.InsertStoredProcedure != null && !this.InsertStoredProcedure.Equals(input.InsertStoredProcedure))) return false;
            if (this.UpdateDeliveryFormat != input.UpdateDeliveryFormat) return false;
            if (this.UpdateStoredProcedure != input.UpdateStoredProcedure || (this.UpdateStoredProcedure != null && !this.UpdateStoredProcedure.Equals(input.UpdateStoredProcedure))) return false;
            if (this.DeleteDeliveryFormat != input.DeleteDeliveryFormat) return false;
            if (this.DeleteStoredProcedure != input.DeleteStoredProcedure || (this.DeleteStoredProcedure != null && !this.DeleteStoredProcedure.Equals(input.DeleteStoredProcedure))) return false;

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
                if (this.DestinationObjectName != null) hashCode = hashCode * 59 + this.DestinationObjectName.GetHashCode();
                if (this.DestinationObjectOwner != null) hashCode = hashCode * 59 + this.DestinationObjectOwner.GetHashCode();
                hashCode = hashCode * 59 + this.InsertDeliveryFormat.GetHashCode();
                if (this.InsertStoredProcedure != null) hashCode = hashCode * 59 + this.InsertStoredProcedure.GetHashCode();
                hashCode = hashCode * 59 + this.UpdateDeliveryFormat.GetHashCode();
                if (this.UpdateStoredProcedure != null) hashCode = hashCode * 59 + this.UpdateStoredProcedure.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteDeliveryFormat.GetHashCode();
                if (this.DeleteStoredProcedure != null) hashCode = hashCode * 59 + this.DeleteStoredProcedure.GetHashCode();
                return hashCode;
            }
        }
    }
}
