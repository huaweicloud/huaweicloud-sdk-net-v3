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
    /// 
    /// </summary>
    public class ListMessageTraceRespTrace 
    {
        /// <summary>
        /// 轨迹类型
        /// </summary>
        /// <value>轨迹类型</value>
        [JsonConverter(typeof(EnumClassConverter<TraceTypeEnum>))]
        public class TraceTypeEnum
        {
            /// <summary>
            /// Enum PUB for value: Pub
            /// </summary>
            public static readonly TraceTypeEnum PUB = new TraceTypeEnum("Pub");

            /// <summary>
            /// Enum SUB for value: Sub
            /// </summary>
            public static readonly TraceTypeEnum SUB = new TraceTypeEnum("Sub");

            /// <summary>
            /// Enum ENDTRANSACTION for value: EndTransaction
            /// </summary>
            public static readonly TraceTypeEnum ENDTRANSACTION = new TraceTypeEnum("EndTransaction");

            private static readonly Dictionary<string, TraceTypeEnum> StaticFields =
            new Dictionary<string, TraceTypeEnum>()
            {
                { "Pub", PUB },
                { "Sub", SUB },
                { "EndTransaction", ENDTRANSACTION },
            };

            private string _value;

            public TraceTypeEnum()
            {

            }

            public TraceTypeEnum(string value)
            {
                _value = value;
            }

            public static TraceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TraceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TraceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TraceTypeEnum a, TraceTypeEnum b)
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

            public static bool operator !=(TraceTypeEnum a, TraceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 消息类型。
        /// </summary>
        /// <value>消息类型。</value>
        [JsonConverter(typeof(EnumClassConverter<MsgTypeEnum>))]
        public class MsgTypeEnum
        {
            /// <summary>
            /// Enum NORMAL_MSG for value: Normal_Msg
            /// </summary>
            public static readonly MsgTypeEnum NORMAL_MSG = new MsgTypeEnum("Normal_Msg");

            /// <summary>
            /// Enum TRANS_MSG_HALF for value: Trans_Msg_Half
            /// </summary>
            public static readonly MsgTypeEnum TRANS_MSG_HALF = new MsgTypeEnum("Trans_Msg_Half");

            /// <summary>
            /// Enum TRANS_MSG_COMMIT for value: Trans_msg_Commit
            /// </summary>
            public static readonly MsgTypeEnum TRANS_MSG_COMMIT = new MsgTypeEnum("Trans_msg_Commit");

            /// <summary>
            /// Enum DELAY_MSG for value: Delay_Msg
            /// </summary>
            public static readonly MsgTypeEnum DELAY_MSG = new MsgTypeEnum("Delay_Msg");

            private static readonly Dictionary<string, MsgTypeEnum> StaticFields =
            new Dictionary<string, MsgTypeEnum>()
            {
                { "Normal_Msg", NORMAL_MSG },
                { "Trans_Msg_Half", TRANS_MSG_HALF },
                { "Trans_msg_Commit", TRANS_MSG_COMMIT },
                { "Delay_Msg", DELAY_MSG },
            };

            private string _value;

            public MsgTypeEnum()
            {

            }

            public MsgTypeEnum(string value)
            {
                _value = value;
            }

            public static MsgTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MsgTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MsgTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MsgTypeEnum a, MsgTypeEnum b)
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

            public static bool operator !=(MsgTypeEnum a, MsgTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 事务状态。
        /// </summary>
        /// <value>事务状态。</value>
        [JsonConverter(typeof(EnumClassConverter<TransactionStateEnum>))]
        public class TransactionStateEnum
        {
            /// <summary>
            /// Enum COMMIT_MESSAGE for value: COMMIT_MESSAGE
            /// </summary>
            public static readonly TransactionStateEnum COMMIT_MESSAGE = new TransactionStateEnum("COMMIT_MESSAGE");

            /// <summary>
            /// Enum ROLLBACK_MESSAGE for value: ROLLBACK_MESSAGE
            /// </summary>
            public static readonly TransactionStateEnum ROLLBACK_MESSAGE = new TransactionStateEnum("ROLLBACK_MESSAGE");

            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly TransactionStateEnum UNKNOW = new TransactionStateEnum("UNKNOW");

            private static readonly Dictionary<string, TransactionStateEnum> StaticFields =
            new Dictionary<string, TransactionStateEnum>()
            {
                { "COMMIT_MESSAGE", COMMIT_MESSAGE },
                { "ROLLBACK_MESSAGE", ROLLBACK_MESSAGE },
                { "UNKNOW", UNKNOW },
            };

            private string _value;

            public TransactionStateEnum()
            {

            }

            public TransactionStateEnum(string value)
            {
                _value = value;
            }

            public static TransactionStateEnum FromValue(string value)
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

                if (this.Equals(obj as TransactionStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TransactionStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TransactionStateEnum a, TransactionStateEnum b)
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

            public static bool operator !=(TransactionStateEnum a, TransactionStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否成功。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// 轨迹类型
        /// </summary>
        [JsonProperty("trace_type", NullValueHandling = NullValueHandling.Ignore)]
        public TraceTypeEnum TraceType { get; set; }
        /// <summary>
        /// 时间。
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Timestamp { get; set; }

        /// <summary>
        /// 生产组或消费组。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 耗时。
        /// </summary>
        [JsonProperty("cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CostTime { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 消费状态。
        /// </summary>
        [JsonProperty("consume_status", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ConsumeStatus { get; set; }

        /// <summary>
        /// 主题名称。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 消息ID。
        /// </summary>
        [JsonProperty("msg_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MsgId { get; set; }

        /// <summary>
        /// offset消息ID。
        /// </summary>
        [JsonProperty("offset_msg_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetMsgId { get; set; }

        /// <summary>
        /// 消息的标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 消息的keys。
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public string Keys { get; set; }

        /// <summary>
        /// 存储消息的主机IP。
        /// </summary>
        [JsonProperty("store_host", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreHost { get; set; }

        /// <summary>
        /// 产生消息的主机IP。
        /// </summary>
        [JsonProperty("client_host", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientHost { get; set; }

        /// <summary>
        /// 重试次数。
        /// </summary>
        [JsonProperty("retry_times", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryTimes { get; set; }

        /// <summary>
        /// 消息体长度。
        /// </summary>
        [JsonProperty("body_length", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BodyLength { get; set; }

        /// <summary>
        /// 消息类型。
        /// </summary>
        [JsonProperty("msg_type", NullValueHandling = NullValueHandling.Ignore)]
        public MsgTypeEnum MsgType { get; set; }
        /// <summary>
        /// 事务状态。
        /// </summary>
        [JsonProperty("transaction_state", NullValueHandling = NullValueHandling.Ignore)]
        public TransactionStateEnum TransactionState { get; set; }
        /// <summary>
        /// 事务ID。
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// 是否为事务回查的响应。
        /// </summary>
        [JsonProperty("from_transaction_check", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FromTransactionCheck { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMessageTraceRespTrace {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  traceType: ").Append(TraceType).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  costTime: ").Append(CostTime).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  consumeStatus: ").Append(ConsumeStatus).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  msgId: ").Append(MsgId).Append("\n");
            sb.Append("  offsetMsgId: ").Append(OffsetMsgId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  keys: ").Append(Keys).Append("\n");
            sb.Append("  storeHost: ").Append(StoreHost).Append("\n");
            sb.Append("  clientHost: ").Append(ClientHost).Append("\n");
            sb.Append("  retryTimes: ").Append(RetryTimes).Append("\n");
            sb.Append("  bodyLength: ").Append(BodyLength).Append("\n");
            sb.Append("  msgType: ").Append(MsgType).Append("\n");
            sb.Append("  transactionState: ").Append(TransactionState).Append("\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  fromTransactionCheck: ").Append(FromTransactionCheck).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMessageTraceRespTrace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMessageTraceRespTrace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.TraceType == input.TraceType ||
                    (this.TraceType != null &&
                    this.TraceType.Equals(input.TraceType))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.CostTime == input.CostTime ||
                    (this.CostTime != null &&
                    this.CostTime.Equals(input.CostTime))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.ConsumeStatus == input.ConsumeStatus ||
                    (this.ConsumeStatus != null &&
                    this.ConsumeStatus.Equals(input.ConsumeStatus))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.MsgId == input.MsgId ||
                    (this.MsgId != null &&
                    this.MsgId.Equals(input.MsgId))
                ) && 
                (
                    this.OffsetMsgId == input.OffsetMsgId ||
                    (this.OffsetMsgId != null &&
                    this.OffsetMsgId.Equals(input.OffsetMsgId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Keys == input.Keys ||
                    (this.Keys != null &&
                    this.Keys.Equals(input.Keys))
                ) && 
                (
                    this.StoreHost == input.StoreHost ||
                    (this.StoreHost != null &&
                    this.StoreHost.Equals(input.StoreHost))
                ) && 
                (
                    this.ClientHost == input.ClientHost ||
                    (this.ClientHost != null &&
                    this.ClientHost.Equals(input.ClientHost))
                ) && 
                (
                    this.RetryTimes == input.RetryTimes ||
                    (this.RetryTimes != null &&
                    this.RetryTimes.Equals(input.RetryTimes))
                ) && 
                (
                    this.BodyLength == input.BodyLength ||
                    (this.BodyLength != null &&
                    this.BodyLength.Equals(input.BodyLength))
                ) && 
                (
                    this.MsgType == input.MsgType ||
                    (this.MsgType != null &&
                    this.MsgType.Equals(input.MsgType))
                ) && 
                (
                    this.TransactionState == input.TransactionState ||
                    (this.TransactionState != null &&
                    this.TransactionState.Equals(input.TransactionState))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.FromTransactionCheck == input.FromTransactionCheck ||
                    (this.FromTransactionCheck != null &&
                    this.FromTransactionCheck.Equals(input.FromTransactionCheck))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.TraceType != null)
                    hashCode = hashCode * 59 + this.TraceType.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.CostTime != null)
                    hashCode = hashCode * 59 + this.CostTime.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.ConsumeStatus != null)
                    hashCode = hashCode * 59 + this.ConsumeStatus.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.MsgId != null)
                    hashCode = hashCode * 59 + this.MsgId.GetHashCode();
                if (this.OffsetMsgId != null)
                    hashCode = hashCode * 59 + this.OffsetMsgId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.StoreHost != null)
                    hashCode = hashCode * 59 + this.StoreHost.GetHashCode();
                if (this.ClientHost != null)
                    hashCode = hashCode * 59 + this.ClientHost.GetHashCode();
                if (this.RetryTimes != null)
                    hashCode = hashCode * 59 + this.RetryTimes.GetHashCode();
                if (this.BodyLength != null)
                    hashCode = hashCode * 59 + this.BodyLength.GetHashCode();
                if (this.MsgType != null)
                    hashCode = hashCode * 59 + this.MsgType.GetHashCode();
                if (this.TransactionState != null)
                    hashCode = hashCode * 59 + this.TransactionState.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.FromTransactionCheck != null)
                    hashCode = hashCode * 59 + this.FromTransactionCheck.GetHashCode();
                return hashCode;
            }
        }
    }
}
