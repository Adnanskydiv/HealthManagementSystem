//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS.HealthTrack.Web.Data.Model.Security
{
    using System;
    using System.Collections.Generic;
    
    public partial class HealthTrackUser
    {
        public string User_ID { get; set; }
        public string Password { get; set; }
        public string EntryType { get; set; }
        public bool Enabled { get; set; }
        public bool Visible { get; set; }
        public bool Privileged { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string UserPosition { get; set; }
        public string Email { get; set; }
        public string LetterSignature_L1 { get; set; }
        public string LetterSignature_L2 { get; set; }
        public bool Remote { get; set; }
        public string StartupMode { get; set; }
        public int CountAdd { get; set; }
        public int CountModify { get; set; }
        public int CountDelete { get; set; }
        public int CountView { get; set; }
        public int CountLogon { get; set; }
        public int CountTimeouts { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public string Workstation_ID { get; set; }
        public Nullable<System.DateTime> LastLogon { get; set; }
        public Nullable<System.DateTime> LastLogoff { get; set; }
        public string LastDiaryDefaultType { get; set; }
        public Nullable<int> LastBillingLocation { get; set; }
        public Nullable<int> diarySlotSize { get; set; }
        public Nullable<int> diaryColumns { get; set; }
        public Nullable<int> diarySlotOption1 { get; set; }
        public Nullable<int> diarySlotOption2 { get; set; }
        public Nullable<int> diarySlotOption3 { get; set; }
        public Nullable<int> diarySlotOption4 { get; set; }
        public bool diaryEnableMulti { get; set; }
        public Nullable<byte> lblPrinterType { get; set; }
        public Nullable<byte> lblColType { get; set; }
        public Nullable<byte> lblTypeA { get; set; }
        public Nullable<byte> lblTypeB { get; set; }
        public Nullable<byte> lblTypeC { get; set; }
        public Nullable<byte> lblTypeD { get; set; }
        public Nullable<byte> lblTypeE { get; set; }
        public Nullable<byte> lblTypeF { get; set; }
        public string lblPrinterName { get; set; }
        public Nullable<byte> lblPrinterTray { get; set; }
        public Nullable<int> LastDiaryRoom { get; set; }
        public Nullable<int> LastDiaryMO { get; set; }
        public Nullable<int> LastPatientLoaded { get; set; }
        public bool LoadDiaryOnStartup { get; set; }
        public bool RememberLastPatientSearch { get; set; }
        public bool DisplayHealthtrackChangeLog { get; set; }
        public string TaskDefaultGroup { get; set; }
        public bool TaskDefaultToGroup { get; set; }
        public bool AllocationDefaultVisible { get; set; }
        public string DirectoryShortcut1 { get; set; }
        public string DirectoryShortcut2 { get; set; }
        public string DirectoryShortcut3 { get; set; }
        public Nullable<int> quickBillDefaultGroupingSet { get; set; }
        public Nullable<int> role_ID { get; set; }
        public Nullable<byte> DM_roleWho { get; set; }
        public string DM_delegateTo { get; set; }
        public string DM_assignTo { get; set; }
        public bool diaryShowsPreferredName { get; set; }
        public string DM_group { get; set; }
        public string prefDocSecurity { get; set; }
        public bool ExternalSearch { get; set; }
        public string AutoOpenPreference1 { get; set; }
        public string AutoOpenPreference2 { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> PathDef_SetID { get; set; }
        public bool DefaultDocManagementToPreview { get; set; }
        public string DefaultClinicalRecordDisplayMode { get; set; }
        public bool HideClinicalNoteShortcutInDiary { get; set; }
        public Nullable<byte> IgnoreMIMSDrugDrugInteractionsLevel { get; set; }
        public bool MIMSLicenseReviewed { get; set; }
        public short WordEditorOption { get; set; }
        public Nullable<int> DefaultEpisode { get; set; }
        public Nullable<int> DefaultImportCategory { get; set; }
        public bool DisableWindowPositionSaving { get; set; }
    }
}