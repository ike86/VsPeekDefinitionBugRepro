namespace VsPeekDefinitionBugRepro
{
    class FirstLevel
    {
        public static void Do()
        {
            SecondLevel.Do();
        }
    }
}
