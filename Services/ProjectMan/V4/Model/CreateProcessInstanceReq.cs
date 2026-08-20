using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateProcessInstanceReq 
    {

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 是否需要决策人审批
        /// </summary>
        [JsonProperty("need_approval", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedApproval { get; set; }

        /// <summary>
        /// 计划完成日期时间戳，不可早于计划开始日期
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// 计划开始日期时间戳，不可晚于计划完成日期
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 抄送人列表
        /// </summary>
        [JsonProperty("cc", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// 关联wiki
        /// </summary>
        [JsonProperty("attachWikis", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttachWikis { get; set; }

        /// <summary>
        /// 关联文件
        /// </summary>
        [JsonProperty("attachDocuments", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttachDocuments { get; set; }

        /// <summary>
        /// 决策人
        /// </summary>
        [JsonProperty("ccbs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateProcessInstanceReqCcbs> Ccbs { get; set; }

        /// <summary>
        /// 评审专家
        /// </summary>
        [JsonProperty("opinions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateProcessInstanceReqOpinions> Opinions { get; set; }

        /// <summary>
        /// 评审对象
        /// </summary>
        [JsonProperty("cos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateProcessInstanceReqCos> Cos { get; set; }

        /// <summary>
        /// 关联文件名
        /// </summary>
        [JsonProperty("local_attachment_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LocalAttachmentNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProcessInstanceReq {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  needApproval: ").Append(NeedApproval).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  cc: ").Append(Cc).Append("\n");
            sb.Append("  attachWikis: ").Append(AttachWikis).Append("\n");
            sb.Append("  attachDocuments: ").Append(AttachDocuments).Append("\n");
            sb.Append("  ccbs: ").Append(Ccbs).Append("\n");
            sb.Append("  opinions: ").Append(Opinions).Append("\n");
            sb.Append("  cos: ").Append(Cos).Append("\n");
            sb.Append("  localAttachmentNames: ").Append(LocalAttachmentNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProcessInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProcessInstanceReq input)
        {
            if (input == null) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.NeedApproval != input.NeedApproval || (this.NeedApproval != null && !this.NeedApproval.Equals(input.NeedApproval))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Cc != input.Cc || (this.Cc != null && input.Cc != null && !this.Cc.SequenceEqual(input.Cc))) return false;
            if (this.AttachWikis != input.AttachWikis || (this.AttachWikis != null && input.AttachWikis != null && !this.AttachWikis.SequenceEqual(input.AttachWikis))) return false;
            if (this.AttachDocuments != input.AttachDocuments || (this.AttachDocuments != null && input.AttachDocuments != null && !this.AttachDocuments.SequenceEqual(input.AttachDocuments))) return false;
            if (this.Ccbs != input.Ccbs || (this.Ccbs != null && input.Ccbs != null && !this.Ccbs.SequenceEqual(input.Ccbs))) return false;
            if (this.Opinions != input.Opinions || (this.Opinions != null && input.Opinions != null && !this.Opinions.SequenceEqual(input.Opinions))) return false;
            if (this.Cos != input.Cos || (this.Cos != null && input.Cos != null && !this.Cos.SequenceEqual(input.Cos))) return false;
            if (this.LocalAttachmentNames != input.LocalAttachmentNames || (this.LocalAttachmentNames != null && input.LocalAttachmentNames != null && !this.LocalAttachmentNames.SequenceEqual(input.LocalAttachmentNames))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.NeedApproval != null) hashCode = hashCode * 59 + this.NeedApproval.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Cc != null) hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.AttachWikis != null) hashCode = hashCode * 59 + this.AttachWikis.GetHashCode();
                if (this.AttachDocuments != null) hashCode = hashCode * 59 + this.AttachDocuments.GetHashCode();
                if (this.Ccbs != null) hashCode = hashCode * 59 + this.Ccbs.GetHashCode();
                if (this.Opinions != null) hashCode = hashCode * 59 + this.Opinions.GetHashCode();
                if (this.Cos != null) hashCode = hashCode * 59 + this.Cos.GetHashCode();
                if (this.LocalAttachmentNames != null) hashCode = hashCode * 59 + this.LocalAttachmentNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
