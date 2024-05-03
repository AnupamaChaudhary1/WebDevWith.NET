using System.Formats.Asn1;
using Microsoft.Net.Http.Headers;

public class Session
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string? Details { get; set; }
    public DateTime Start { get; set; }
    public float DurationInHours { get; set; }
    public int? CourseId { get; set; }
    public Course? Course { get; set; }

}

//coursse has one to many relation

// class A {
// }
// class B{
//     //A a=new A(); //tight coupling/ hard
//     //dependency injection
//     //constuctor injection
//     A a;
//     private A a1;

//     public B(A a2){
//         a1 = a2;
//     }
// }
