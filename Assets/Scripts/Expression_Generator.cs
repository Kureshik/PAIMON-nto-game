using System.Data;
using UnityEngine;


class Expression_Generator : MonoBehaviour
{

    string[] New_Equasion(string difficulty)
    {
        string[] templates_easy =
        {
            "a*b",
            "a/b",
            "a+b",
            "a-b",
        };
        string[] templates_normal =
        {
            "a*b+c",
            "a*b-c",
            "a*b/c",
            "a+b+c",
            "a+b-c",
            "a+b/c",
            "a-b+c",
            "a-b-c",
            "a-b/c",
        };
        string[] templates_hard =
        {
            "(a+b)*(c+d)",
            "(a+b)*(c-d)",
            "(a-b)*(c+d)",
            "(a-b)*(c-d)",
            "(a+b)/(c+d)",
            "(a+b)/(c-d)",
            "(a-b)/(c+d)",
            "(a-b)/(c-d)",
            "(a+b/c)*d",
            "(a-b/c)*d",
            "(a+b*c)/d",
            "(a-b*c)/d",
        };
        string expression = "", a, b, c, d;

        a = Random.Range(1, 100).ToString();
        b = Random.Range(1, 100).ToString();
        c = Random.Range(1, 100).ToString();
        d = Random.Range(1, 100).ToString();
        switch (difficulty)
        {
            case "easy":
                expression = templates_easy[Random.Range(0, templates_easy.Length - 1)];
                expression = expression.Replace("a", a).Replace("b", b);
                break;
            case "normal":
                expression = templates_normal[Random.Range(0, templates_normal.Length - 1)];
                expression = expression.Replace("a", a).Replace("b", b).Replace("c", c);
                break;
            case "hard":
                expression = templates_hard[Random.Range(0, templates_hard.Length - 1)];
                expression = expression.Replace("a", a).Replace("b", b).Replace("c", c).Replace("d", d);
                break;
        }

        DataTable dt = new DataTable();
        float solution = (float)dt.Compute(expression, "");

        string[] result = {expression, solution.ToString()};
        return result;
    }

    string[] Generate_Equasion(string difficulty = "easy", int lower_bound = -100, 
        int upper_bound = 100, int preciseness = 1)
    {
        string[] equasion = New_Equasion(difficulty);
        float solution = float.Parse(equasion[1]), round_factor = Mathf.Pow(10, preciseness);

        while (Mathf.Round(solution*round_factor) / round_factor != solution || 
            solution > upper_bound || solution < lower_bound)
        {
            equasion = New_Equasion(difficulty);
            solution = float.Parse(equasion[1]);
        }

        return equasion;
    }
}