**Checklist** <!-- Mandatory -->
 
Please verify the following checklist in order:
- [ ] If releasing module changes, the Pull Request title is prepended with "[\<Azure Stack Hub Release Version\>]". E.g., a title may be "[2301] Compute RP changes". Otherwise, this is not necessary.
- [ ] Updated origin `dev` branch locally. (`git fetch origin dev`)
- [ ] The Pull Request has a single commit. The following is a standard way to achieve a single commit:
    - `git checkout feature`
    - `git rebase origin/dev -i`
    - In the VIM editor press `ESC` and `i` to enter edit mode.
    - Select commits to fixup or squash commits (instructions are in the editor).
    - Press `ESC`, type `:wq`, and press `Enter` to save and quit.
- [ ] Resolved any rebase conflicts (basically merge conflicts).
- [ ] Commits are rebased on top of latest remote `dev` branch.
- [ ] The changes are tested. Make sure to test after the rebase step.
- [ ] Updated remote feature branch. (Force push if you've rebased onto new changes from dev: `git push origin feature -f`)

**Description** <!-- Mandatory -->
<!-- Give a detailed description of the changes. For small changes, you can just copy the single commit message. If releasing a new module version, this can be the same as the changelog update. If for some reason the pull request requires multiple commits, explain why that is required as well. -->