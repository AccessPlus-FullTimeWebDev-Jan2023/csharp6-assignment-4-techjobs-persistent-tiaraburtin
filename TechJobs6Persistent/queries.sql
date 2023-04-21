-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.

-- Employers: ID (int), Name (longtext), Location (longtext)
-- Jobs: ID (int), Name (longtext), EmployerId (int)
-- JobSkills: JobId (int), SkillsId (int)
-- Skills: ID (int), SkillName (varchar50)


--Part 2: Write a query to list the names of the employers in St. Louis City.

-- select location 
-- from employers
-- where location = 'st. louis';


--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.

--select skillname
-- from skills
-- right join jobskills 
-- on jobskills.skillsid = skills.id
-- where skillsid is not null
-- order by skillname asc