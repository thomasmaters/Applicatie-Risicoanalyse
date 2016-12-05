using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie_Risicoanalyse.Globals
{
    public static class ARA_Constants
    {
        //Application constants.
        public const float noScaleFontSize     = 15F;
        public const int randomPasswordLength = 10;

        //New risk creation constants.
        public const int hazardSituationMinimalTextLength = 25;
        public const int hazardEventMinimalTextLength     = 25;

        //Document generation constants.
        public const string riskAssesmentReportFileName    = "Risk Assessment Report.docx";
        public const string remainingRiskReportFileName    = "Remaining Rest-Risk Report.docx";
        public const string performanceLevelReportFileName = "Performance Level Report.docx";

        //Project states.
        public const string draft      = "DRAFT";
        public const string forReview  = "FORREVIEW";
        public const string finalDraft = "FINALDRAFT";
        public const string closed     = "CLOSED";

        //Messagebox texts.
        public const string messageBoxSuccesCopiedRisks                   = "Succesfully copied the selected risks to the current project.";
        public const string messageBoxSuccesCopiedRisksHead               = "Succesfull copied risks!";
        public const string messageBoxReviewerComment                     = "The reviewer of this risk gave the following comment:\n";
        public const string messageBoxReviewerCommentHeader               = "Reviewer comment.";
        public const string messageBoxNewRiskVersion                      = "Succesfully created a new Version of the risk!";
        public const string messageBoxNewRiskVersionHeader                = "New version of risk created!";
        public const string messageBoxRiskProjectSpecific                 = "Succesfully made this risk project specific.";
        public const string messageBoxRiskProjectSpecificHeader           = "Project specific risk!";
        public const string messageBoxSortingOptionNeeded                 = "Select a sorting option before generating any report!";
        public const string messageBoxSortingOptionNeededHeader           = "Sorting option missing.";
        public const string messageBoxCoudntCreateRisk                    = "The risk couldn't be created, because not all required fields where filled.";
        public const string messageBoxCoudntCreateRiskHeader              = "Could not create new risk.";
        public const string messageBoxAddedRiskToStandard                 = "A new risk has been added to the standard!";
        public const string messageBoxAddedRiskToStandardHeader           = "New Risk created.";
        public const string messageBoxConfirmProjectReview                = "Are you sure to mark this project for review? You can't change any risks until another user has reviewed this project!";
        public const string messageBoxConfirmProjectReviewHeader          = "Are you sure?";
        public const string messageBoxConfirmFinalDraft                   = "Are you sure to end the review sessie? The project will be marked as FINALDRAFT and can't be changed afterwards!";
        public const string messageBoxConfirmFinalDraftHeader             = "Are you sure?";
        public const string messageBoxConfirmDraft                        = "Are you sure to end the review sessie? The project will be marked as a new DRAFT!";
        public const string messageBoxConfirmDraftHeader                  = "Are you sure?";
        public const string messageBoxConfirmCloseProject                 = "Are you sure you want to close the project? It can't be changed afterwards!";
        public const string messageBoxConfirmCloseProjectHeader           = "Are you sure?";
        public const string messageBoxProjectAlreadyOpen                  = "This project is already opend!";
        public const string messageBoxProjectAlreadyOpenHeader            = "Info.";
        public const string messageBoxDocumentsGenerated                  = "Document generated!";
        public const string messageBoxDocumentsGeneratedHeader            = "Completed!";
        public const string messageBoxSomethingWrongWhileGenerating       = "";
        public const string messageBoxSomethingWrongWhileGeneratingHeader = "Something went wrong while generating.";
        public const string messageBoxLoginFailded                        = "Couldn't login, check your username or password!";
        public const string messageBoxLoginFaildedHeader                  = "Login failed.";
        public const string messageBoxLoginNewUser                        = "Succesfully added a new user to the database.";
        public const string messageBoxLoginNewUser1                       = "This password has also been copied to your clipboard.";
        public const string messageBoxLoginNewUserHeader                  = "Login failed.";
        public const string messageBoxProjectRevisionCreated              = "Succesfully created a project revision.";
        public const string messageBoxProjectRevisionCreatedHeader        = "Revision created.";
        public const string messageBoxProjectRevisionFailed               = "Failed to create a project revision. Contact the administrator if this problem keeps occuring. ";
        public const string messageBoxProjectRevisionFailedHeader         = "Failed to create a project revision.";
    }
}
