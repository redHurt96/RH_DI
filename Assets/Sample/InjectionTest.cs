using RH.Utilities.ServiceLocator;
using UnityEngine;

public class InjectionTest : MonoBehaviour
{
    [Inject] private SomeService _someService;
}

public class SomeService
{
    public string SomeValue = "123";
}
