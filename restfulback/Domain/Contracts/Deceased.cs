namespace restfulback.Domain
{
    public class AddDeceasedData
    {
        public required string FullName { get; set; }
        public required string Gender { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required DateTime DateOfDeath { get; set; }
        public required int Age { get; set; }
        public required string Address { get; set; }
        public string? CauseOfDeath { get; set; }
        public string? CHINumber { get; set; }
        public required string NextOfKinName { get; set; }
        public required string NextOfKinGender { get; set; }
        public required string RelationshipToDeceased { get; set; }
        public required string NextOfKinEmail { get; set; }
        public required string NextOfKinPhone { get; set; }
        public required string NextOfKinAddress { get; set; }
        public required string RegistrationOffice { get; set; }
    }
    public class DeceasedData
    {
        public Guid Id { get; set; }
        public required string FullName { get; set; }
        public required string Gender { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required DateTime DateOfDeath { get; set; }
        public int Age { get; set; }
        public required string Address { get; set; }
        public string? CauseOfDeath { get; set; }
        public required string CHINumber { get; set; }
        public required string NextOfKinName { get; set; }
        public required string NextOfKinGender { get; set; }
        public required string RelationshipToDeceased { get; set; }
        public required string NextOfKinEmail { get; set; }
        public required string NextOfKinPhone { get; set; }
        public required string NextOfKinAddress { get; set; }
        public required string RegistrationOffice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }


}