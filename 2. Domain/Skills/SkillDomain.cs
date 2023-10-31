using _3._Data.Model;
using _3._Data.Skills;
using _2._Domain.Workers;
using _2._Domain.Exceptions;
using System.Threading.Tasks;

namespace _2._Domain.Skills
{
    public class SkillDomain : ISkillDomain
    {
        private readonly ISkillData _skillData;
        private readonly IWorkerDomain _workerDomain;

        public SkillDomain(ISkillData skillData, IWorkerDomain workerDomain)
        {
            _skillData = skillData;
            _workerDomain = workerDomain;
        }

        public async Task<bool> CreateAsync(Skill skill, int workerId)
        {
            var existsWorker = await _workerDomain.ExistsByWorkerId(workerId);

            if (!existsWorker)
            {
                return false;
            }

            skill.WorkerId = workerId;
            return await _skillData.CreateAsync(skill);
        }

        public async Task<bool> UpdateAsync(Skill skill, int id)
        {
            Skill skillToBeUpdated = await _skillData.GetByIdAsync(id);

            if (skillToBeUpdated == null)
            {
                throw new InvalidSkillIDException();
            }

            return await _skillData.UpdateAsync(skill, id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Skill skillToBeDeleted = await _skillData.GetByIdAsync(id);
            if (skillToBeDeleted != null)
            {
                return await _skillData.DeleteAsync(id);
            }

            throw new InvalidSkillIDException();
        }
    }
}