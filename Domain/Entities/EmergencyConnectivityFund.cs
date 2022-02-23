using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain
{
    public class EmergencyConnectivityFund
    {
        [JsonPropertyName("a_application_number")]
        public string ApplicationNumber { get; set; }
        [JsonPropertyName("a_form_version")]
        public string FormVersion { get; set; }
        [JsonPropertyName("a_application_status")]
        public string ApplicationStatus { get; set; }
        [JsonPropertyName("a_filing_window")]
        public string FilingWindow { get; set; }
        [JsonPropertyName("a_applicant_name")]
        public string ApplicantName { get; set; }
        [JsonPropertyName("a_billed_entity_number")]
        public string BilledEntityNumber { get; set; }
        [JsonPropertyName("a_billed_entity_city")]
        public string BilledEntityCity { get; set; }
        [JsonPropertyName("a_billed_entity_state")]
        public string BilledEntityState { get; set; }
        [JsonPropertyName("a_applicant_type")]
        public string ApplicantType { get; set; }
        [JsonPropertyName("a_consulting_firm")]
        public string ConsultingFirm { get; set; }
        [JsonPropertyName("a_certified_datetime")]
        public DateTime CertifiedDatetime { get; set; }
        [JsonPropertyName("a_window_status")]
        public string WindowStatus { get; set; }
        [Key]
        [JsonPropertyName("a_funding_request_number")]
        public string FundingRequestNumber { get; set; }
        [JsonPropertyName("a_funding_request_status")]
        public string FundingRequestStatus { get; set; }
        [JsonPropertyName("a_service_type")]
        public string ServiceType { get; set; }
        [JsonPropertyName("a_service_provider_name")]
        public string ServiceProviderName { get; set; }
        [JsonPropertyName("a_service_provider_identification_number")]
        public string ServiceProviderIdentificationNumber { get; set; }
        [JsonPropertyName("a_invoicing_method")]
        public string InvoicingMethod { get; set; }
        [JsonPropertyName("a_invoice_deadline_date")]
        public DateTime InvoiceDeadlineDate { get; set; }
        [JsonPropertyName("a_obligation_file")]
        public string ObligationFile { get; set; }
        [JsonPropertyName("a_fcdl_date")]
        public DateTime FcdlDate { get; set; }
        [JsonPropertyName("a_fcdl_comment_for_frn")]
        public string FcdlCommentForFrn { get; set; }
        [JsonPropertyName("a_frn_total_charges")]
        public string FrnTotalCharges { get; set; }
        [JsonPropertyName("a_frn_approved_amount")]
        public string FrnApprovedAmount { get; set; }
        [JsonPropertyName("a_frn_authorized_disbursement")]
        public string FrnAuthorizedDisbursement { get; set; }
        [JsonPropertyName("a_last_updated_datetime")]
        public DateTime LastUpdatedDatetime { get; set; }
    }
}
