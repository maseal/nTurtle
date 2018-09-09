using NGettext;

namespace NTurtle.Core.Interpreter
{
    public partial class Translator
    {
        private void FillTranslatedExamples(Catalog localizer)
        {
            string exampleName;

            exampleName = GetLocalized(
                "triangle", localizer);
            examples[exampleName] = LocalizeScript(
                "@(reset)\n" +
                "@(repeat) 3 {\n" +
                "  @(forward) 100\n" +
                "  @(turnleft) 120\n" +
                "}\n"
            );

            exampleName = GetLocalized(
                "curly", localizer);
            examples[exampleName] = LocalizeScript(
                "@(reset)\n" +
                "@(penup)\n" +
                "@(forward) 50\n" +
                "@(pendown)\n" +
                "\n" +
                "@(repeat) 4 {\n" +
                "  @(for) $x = 1 @(to) 100 {\n" +
                "    @(forward) 10\n" +
                "    @(turnright) 100 - $x\n" +
                "  }\n" +
                "}\n"
            );

            exampleName = GetLocalized(
                "arrow", localizer);
            examples[exampleName] = LocalizeScript(
                "@(reset)\n" +
                "\n" +
                "@(canvassize) 200@(,) 200\n" +
                "@(canvascolor) 0@(,) 0@(,) 0\n" +
                "@(pencolor) 255@(,) 0@(,) 0\n" +
                "@(penwidth) 5\n" +
                "\n" +
                "@(go) 20@(,)20\n" +
                "@(direction) 135\n" +
                "\n" +
                "@(forward) 200\n" +
                "@(turnleft) 135\n" +
                "@(forward) 100\n" +
                "@(turnleft) 135\n" +
                "@(forward) 141\n" +
                "@(turnleft) 135\n" +
                "@(forward) 100\n" +
                "@(turnleft) 45\n" +
                "\n" +
                "@(go) 40@(,) 100"
            );

            exampleName = GetLocalized(
                "flower", localizer);
            examples[exampleName] = LocalizeScript(
                "@(reset)\n" +
                "@(canvascolor) 255@(,) 55@(,) 140\n" +
                "@(pencolor) 160@(,) 0@(,) 255\n" +
                "@(penwidth) 3\n" +
                "\n" +
                "@(repeat) 8 {\n" +
                "  @(repeat) 4 {\n" +
                "    @(forward) 20\n" +
                "    @(turnright) 30\n" +
                "  }\n" +
                "  @(repeat) 7 {\n" +
                "    @(forward) 10\n" +
                "    @(turnright) 15\n" +
                "  }\n" +
                "  @(repeat) 9 {\n" +
                "    @(forward) 3\n" +
                "    @(turnright) 10\n" +
                "  }\n" +
                "}\n" +
                "\n" +
                "@(go) 145@(,) 145\n" +
                "@(direction) 0"
            );
        }
    }
}