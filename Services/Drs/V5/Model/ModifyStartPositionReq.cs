using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 更新增量位点请求体。
    /// </summary>
    public class ModifyStartPositionReq 
    {

        /// <summary>
        /// - MySQL为源通过show master status命令获取源库位点，根据提示分别填写File:Position。例如：mysql-bin.000277:805  文件名只能为1-60个字符且不能包含&lt; &gt; &amp; : \&quot; \\&#39; / \\\\\\\\ 特殊字符，文件编号只能为3-20个数字，binlog事件位置只能为1-20个数字，且总长度不能超过100个字符。格式为：文件名.文件编号:事件位点  - mogo为源的任务，任务的源库日志从位点开始获取（含当前启动位点），位点需设置在oplog范围以内。非集群通过db.getReplicationInfo()直接获得oplog范围，集群通过db.watch([], {startAtOperationTime: Timestamp(xx, xx)})命令，将启动位点填在xx处，校验位点是否在oplog范围以内。格式为：timestamp:incre。timestamp和incre均为范围在1~2,147,483,647之间的整数。
        /// </summary>
        [JsonProperty("file_and_position", NullValueHandling = NullValueHandling.Ignore)]
        public string FileAndPosition { get; set; }

        /// <summary>
        /// MySQL为源的任务需要，通过show master status命令获取源库位点，根据提示填写Executed_Gtid_Set（如果源库为MySQL 5.5版本，则不支持使用同步任务）。 - 不能包含&lt; &gt; &amp; \&quot; \\&#39; / \\\\\\\\ 特殊字符和中文。且不能超过2048个字符
        /// </summary>
        [JsonProperty("gtid_set", NullValueHandling = NullValueHandling.Ignore)]
        public string GtidSet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyStartPositionReq {\n");
            sb.Append("  fileAndPosition: ").Append(FileAndPosition).Append("\n");
            sb.Append("  gtidSet: ").Append(GtidSet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyStartPositionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyStartPositionReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileAndPosition == input.FileAndPosition ||
                    (this.FileAndPosition != null &&
                    this.FileAndPosition.Equals(input.FileAndPosition))
                ) && 
                (
                    this.GtidSet == input.GtidSet ||
                    (this.GtidSet != null &&
                    this.GtidSet.Equals(input.GtidSet))
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
                if (this.FileAndPosition != null)
                    hashCode = hashCode * 59 + this.FileAndPosition.GetHashCode();
                if (this.GtidSet != null)
                    hashCode = hashCode * 59 + this.GtidSet.GetHashCode();
                return hashCode;
            }
        }
    }
}
