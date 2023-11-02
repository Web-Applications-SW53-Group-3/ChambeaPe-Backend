
using _3._Data.Context;
using _3._Data.Skills;
using _3._Data.Model;
using Microsoft.EntityFrameworkCore.Internal;

public class SkillMySQLDataTests
{
    private ChambeaPeContext context;
    private SkillMySQLData skillData;

    public SkillMySQLDataTests()
    {
        context = new ChambeaPeContext();
        skillData = new SkillMySQLData(context);
    }
    [Fact]
    public async Task GetAllAsync_ReturnsListOfAllActiveSkills()
    {
        // Arrange
        // Create a list of active skills.
        var skills = new List<Skill>
        {
            new Skill { Id = 1, Content = "Skill 1" },
            new Skill { Id = 2, Content = "Skill 2" },
            new Skill { Id = 3, Content = "Skill 3" },
        };

        // Add the active skills to the context.
        context.Skills.AddRange(skills);
        await context.SaveChangesAsync();

        // Act
        var actualSkills = await skillData.GetAllAsync();

        // Assert
        Assert.Equal(3, actualSkills.Count);
        Assert.True(actualSkills.All(s => s.IsActive));
    }
    
}
