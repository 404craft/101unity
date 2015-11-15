//define component with a string
//enable or disable target object components en masse
    
void turn(GameObject[] target, string component, bool active)
{
    for (int i = 0; i < target.Length; i++)
    {
        (target[i].GetComponent(component) as MonoBehaviour).enabled = active;
    }
}
