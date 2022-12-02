    using System;
    using StyleCop;
    using StyleCop.Diagnostics;
    using StyleCop.Spelling;
    

    namespace CustomStyleCopRule {

        [SourceAnalyzer (typeof (CsParser))]
        public class CustomSourceAnalyzer : SourceAnalyzer {
            public override void AnalyzeDocument (CodeDocument document) {
                var csharpDocument = document as CsDocument;
                if (csharpDocument != null) {
                    csharpDocument.WalkDocument (
                        new CodeWalkerElementVisitor<CustomSourceAnalyzer> (this.VisitElement),
                        new CodeWalkerStatementVisitor<CustomSourceAnalyzer> (this.VisitStatement),
                        new CodeWalkerExpressionVisitor<CustomSourceAnalyzer> (this.VisitExpression),
                        this);
                }
            }

            private bool VisitElement (CsElement element, CsElement parentElement, CustomSourceAnalyzer context) {
                // Add your code here.
                return true;
            }

            private bool VisitStatement (Statement statement, Expression parentExpression, Statement parentStatement, CsElement parentElement, CustomSourceAnalyzer context) {
                // Add your code here.
                return true;
            }

            private bool VisitExpression (Expression expression, Expression parentExpression, Statement parentStatement, CsElement parentElement, CustomSourceAnalyzer context) {
                // Add your code here.
                return true;
            }
        }
    }